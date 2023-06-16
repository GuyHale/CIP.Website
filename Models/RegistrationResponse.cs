using CIP.Website.Interfaces;

namespace CIP.Website.Models
{
    public class RegistrationResponse : ICustomResponse
    {
        public IEnumerable<string> ErrorMessages { get; set; } = Enumerable.Empty<string>();
        public bool Success { get; set; }
        public User? User { get; set; }
    }
}
