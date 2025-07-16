using CrudApp.Domain.Interfaces;
using CrudApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudApp.Services.Services
{
    public class AuthService : IAuthService
    {
        private readonly IUserRepository _repo;

        public AuthService(IUserRepository repo) => _repo = repo;

        public async Task<User?> Login(string username, string password)
        {
            return await _repo.GetUser(username, password);
        }
    }
}
