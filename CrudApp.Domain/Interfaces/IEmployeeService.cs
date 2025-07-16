using CrudApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudApp.Domain.Interfaces
{
    public interface IEmployeeService
    {
        Task<List<Employee>> GetEmployees();
        Task AddEmployee(Employee p);
        Task<Employee?> GetEmployeeById(int id);
        Task UpdateEmployee(Employee employee);
        Task DeleteEmployee(int id);
    }
}
