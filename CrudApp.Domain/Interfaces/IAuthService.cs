using CrudApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudApp.Domain.Interfaces
{
    public interface IAuthService
    {
        Task<User?> Login(string username, string password);
    }
}
