using CIP.Website.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIP.Website.Interfaces
{
    public interface ICustomAuthentication
    {
        Task<ICustomResponse> Register(User user);
        Task<ICustomResponse> Login(LoginUser loginUser);
    }
}
