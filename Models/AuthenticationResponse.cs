using CIP.Website.Interfaces;

namespace CIP.Website.Models
{
    public class AuthenticationResponse : ICustomResponse
    {
        public IEnumerable<string> ErrorMessages { get; set; } = Enumerable.Empty<string>();
        public bool Success { get; set; }
        public AuthenticatedUser? AuthenticatedUser { get; set; }
    }
}
