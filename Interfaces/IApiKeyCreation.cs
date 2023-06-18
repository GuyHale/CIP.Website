namespace CIP.Website.Interfaces
{
    public interface IApiKeyCreation
    {
        Task<ICustomResponse> CreateApiKey(string apiKey);
    }
}
