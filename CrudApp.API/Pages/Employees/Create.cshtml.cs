using CrudApp.Domain.Interfaces;
using CrudApp.Domain.Models;
using CrudApp.Services.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CrudApp.API.Pages.Employees
{
    [Authorize]
    public class CreateModel : PageModel
    {
        private readonly IEmployeeService _service;
        public string? ErrorMessage { get; set; }

        public CreateModel(IEmployeeService service)
        {
            _service = service;
        }

        [BindProperty]
        public Employee Employee { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                ErrorMessage = "Datos inválidos.";
                return Page();
            }

            try
            {
                await _service.AddEmployee(Employee);
                return RedirectToPage("/Employees/EmployeeList");
            }
            catch (Exception ex)
            {
                ErrorMessage = "Error al guardar: " + ex.Message;
                return Page();
            }
        }
    }
}
