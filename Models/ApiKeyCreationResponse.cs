using CIP.Website.Interfaces;

namespace CIP.Website.Models
{
    public class ApiKeyCreationResponse : ICustomResponse
    {
        public bool Success { get; set; }
        public IEnumerable<string> ErrorMessages { get; set; } = Enumerable.Empty<string>();
    }
}
