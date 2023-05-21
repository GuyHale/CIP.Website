﻿using CIP.Website.Data.Interfaces;

namespace CIP.Website.Data.Models

{
    public class LoginResponse : ICustomResponse
    {
        public IEnumerable<string> ErrorMessages { get; set; } = Enumerable.Empty<string>();
        public bool Success { get; set; }
    }
}
