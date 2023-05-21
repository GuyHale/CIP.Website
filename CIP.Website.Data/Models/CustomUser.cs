using System.ComponentModel.DataAnnotations;

namespace CIP.Website.Data.Models
{
    public class CustomUser
    {
        [Required]
        public string UserName { get; set; } = string.Empty;

        [Required]
        [MinLength(8)]
        public string Password { get; set; } = string.Empty;

        [Required]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;

        public string FirstName { get; set; } = string.Empty;

        public string LastName { get; set; } = string.Empty;
        public string ApiKey { get; set; } = string.Empty;
    }
}
