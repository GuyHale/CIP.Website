using CIP.Website.Data.Interfaces;
using CIP.Website.Data.Models;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CIP.Website.Data.Services
{
    internal class CryptocurrencyService : ICryptocurrency
    {
        private readonly ILogger<CryptocurrencyService> _logger;
        private readonly IHttpClientFactory _httpClientFactory;

        public CryptocurrencyService(ILogger<CryptocurrencyService> logger, IHttpClientFactory httpClientFactory)
        {
            _logger = logger;
            _httpClientFactory = httpClientFactory;
        }
        public async Task<IEnumerable<Cryptocurrency>> Get()
        {
            try
            {
                HttpClient client = _httpClientFactory.CreateClient("CIP.API");
                HttpResponseMessage httpResponseMessage = await client.GetAsync("cip/cryptocurrencies/get");

                if(httpResponseMessage.StatusCode != System.Net.HttpStatusCode.OK)
                {
                    _logger.LogError("Bad request in {MethodName}, StatusCode: {StatusCode}", System.Reflection.MethodBase.GetCurrentMethod()?.Name, httpResponseMessage.StatusCode);
                    return Enumerable.Empty<Cryptocurrency>();
                }

                string cryptocurrenciesJson = await httpResponseMessage.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<IEnumerable<Cryptocurrency>>(cryptocurrenciesJson) ?? Enumerable.Empty<Cryptocurrency>();

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "{MethodName}", System.Reflection.MethodBase.GetCurrentMethod()?.Name);
            }
            return Enumerable.Empty<Cryptocurrency>();  
        }
    }
}
