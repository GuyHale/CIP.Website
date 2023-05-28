﻿namespace CIP.Website.Data.Interfaces
{
    public interface ICustomResponse
    {
        public bool Success { get; set; }
        public IEnumerable<string> ErrorMessages { get; set; }
    }
}
