using System.ComponentModel.DataAnnotations;

namespace CIP.Website.Models
{
    public class AuthenticatedUser
    {
        [Required]
        public string UserName { get; set; } = string.Empty;

        [Required]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;

        [Required]
        public string FirstName { get; set; } = string.Empty;

        [Required]
        public string LastName { get; set; } = string.Empty;

        public string ApiKey { get; set; } = string.Empty;
    }
}
