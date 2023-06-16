using System.ComponentModel.DataAnnotations;

namespace CIP.Website.Models
{
    public class SignUpUser
    {
        [Required]
        public string UserName { get; set; } = string.Empty;

        [Required]
        [MinLength(8)]
        public string Password { get; set; } = string.Empty;

        [Required]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;

        [Required]
        public string FirstName { get; set; } = string.Empty;

        [Required]
        public string LastName { get; set; } = string.Empty;

        public string Salt { get; set; } = string.Empty;
        public string ApiKey { get; set; } = string.Empty;
    }
}
