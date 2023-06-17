﻿using System.ComponentModel.DataAnnotations;

namespace CIP.Website.Models
{
    public class LoginUser
    {
        [Required]
        public string UserName { get; set; } = string.Empty;

        [Required]
        [MinLength(8)]
        public string Password { get; set; } = string.Empty;
    }
}
