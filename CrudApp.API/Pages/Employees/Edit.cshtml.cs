using CrudApp.Domain.Interfaces;
using CrudApp.Domain.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CrudApp.API.Pages.Employees
{
    [Authorize]
    public class EditModel : PageModel
    {
        private readonly IEmployeeService _service;
        public string? ErrorMessage { get; set; }

        public EditModel(IEmployeeService service)
        {
            _service = service;
        }

        [BindProperty]
        public Employee Employee { get; set; }

        public async Task<IActionResult> OnGetAsync(int id)
        {
            try
            {
                var employee = await _service.GetEmployeeById(id);
                if (employee == null) return NotFound();

                Employee = employee;
                return Page();
            }
            catch (Exception ex)
            {
                ErrorMessage = "Error al obtener el empleado: " + ex.Message;
                return Page();
            }
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                ErrorMessage = "Datos inválidos.";
                return Page();
            }

            try
            {
                await _service.UpdateEmployee(Employee);
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
