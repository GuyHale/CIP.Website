using CIP.Website.Data.Interfaces;
using CIP.Website.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIP.Website.Data
{
    public static class ResponseHelpers
    {
        public static ICustomResponse ServerError<T>()  where T : ICustomResponse, new()
        {
            T response = new()
            {
                Success = false,
                ErrorMessages = new string[] { "Something has gone wrong, please try again!" }
            };
            return response;
        }
    }
}
