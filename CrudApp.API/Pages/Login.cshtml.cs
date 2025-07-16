using CrudApp.Data;
using CrudApp.Domain.Interfaces;
using CrudApp.Domain.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CrudApp.API.Pages
{
    public class LoginModel : PageModel
    {
        private readonly AppDbContext _db;
        private readonly IJwtService _jwtService;
        private readonly IAuthService _authService;
        public LoginModel(AppDbContext db, IJwtService jwtService, IAuthService authService)
        {
            _db = db;
            _jwtService = jwtService;
            _authService = authService;
        }

        [BindProperty]
        public User Input { get; set; }

        public string? Token { get; set; }

        public async Task<IActionResult> OnPost()
        {
            var user = await _authService.Login(Input.Username, Input.Password);
            if (user == null)
            {
                ModelState.AddModelError(string.Empty, "Credenciales incorrectas");
                return Page();
            }

            var token = _jwtService.GenerateToken(user.Username);

            Response.Cookies.Append("jwt", token, new CookieOptions
            {
                HttpOnly = true,
                Secure = true,
                SameSite = SameSiteMode.Strict,
                Expires = DateTime.UtcNow.AddHours(1)
            });

            return RedirectToPage("/Employees/EmployeeList");
        }
    }
}
