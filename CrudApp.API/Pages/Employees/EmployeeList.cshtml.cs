using CrudApp.Domain.Interfaces;
using CrudApp.Domain.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace CrudApp.API.Pages.Employees
{
    [Authorize]
    public class EmployeeListModel : PageModel
    {
        private readonly IEmployeeService _service;

        public List<Employee> Employees { get; set; } = [];
        public string? ErrorMessage { get; set; }
        [BindProperty(SupportsGet = true)]
        public string SortOrder { get; set; }

        public EmployeeListModel(IEmployeeService service)
        {
            _service = service;
        }

        public async Task<IActionResult> OnGetAsync(int id)
        {
            try
            {
                Employees = await _service.GetEmployees();

                return Page();
            }
            catch (Exception ex)
            {
                ErrorMessage = "Error al obtener el listado de empleados: " + ex.Message;
                return Page();
            }
        }

        public async Task<IActionResult> OnPostDeleteAsync(int id)
        {
            await _service.DeleteEmployee(id);
            return RedirectToPage();
        }
    }
}
