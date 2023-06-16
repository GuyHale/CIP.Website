using CIP.Website.Helpers;
using CIP.Website.Interfaces;
using CIP.Website.Models;
using Newtonsoft.Json;

namespace CIP.Website.Services
{
    public class CustomAuthenticationService : ICustomAuthentication
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly ILogger<CustomAuthenticationService> _logger;

        public CustomAuthenticationService(IHttpClientFactory httpClientFactory, ILogger<CustomAuthenticationService> logger)
        {
            _httpClientFactory = httpClientFactory;
            _logger = logger;
        }

        public async Task<ICustomResponse> Register(CustomUser user)
        {
            try
            {
                user.ApiKey = Guid.NewGuid().ToString();
                HttpClient httpClient = _httpClientFactory.CreateClient("CIP.API");
                var res = await httpClient.PostAsJsonAsync<CustomUser>("api/authenticate/register", user);

                if (!res.IsSuccessStatusCode)
                {
                    return ResponseHelpers.ServerError<RegistrationResponse>();
                }
                string jsonResponse = await res.Content.ReadAsStringAsync();
                RegistrationResponse customResponse = JsonConvert.DeserializeObject<RegistrationResponse>(jsonResponse) ?? new();
                return customResponse;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, System.Reflection.MethodBase.GetCurrentMethod()?.Name);
            }
            return ResponseHelpers.ServerError<RegistrationResponse>();
        }

        public async Task<ICustomResponse> Login(LoginUser loginUser)
        {
            try
            {
                HttpClient httpClient = _httpClientFactory.CreateClient("CIP.API");
                var res = await httpClient.PostAsJsonAsync<LoginUser>("api/authenticate/login", loginUser);

                if (!res.IsSuccessStatusCode)
                {
                    return ResponseHelpers.ServerError<LoginResponse>();
                }
                string jsonResponse = await res.Content.ReadAsStringAsync();
                RegistrationResponse customResponse = JsonConvert.DeserializeObject<RegistrationResponse>(jsonResponse) ?? new();
                return customResponse;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, System.Reflection.MethodBase.GetCurrentMethod()?.Name);
            }
            return ResponseHelpers.ServerError<LoginResponse>();
        }
    }
}
