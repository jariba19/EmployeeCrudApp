using CrudApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudApp.Domain.Interfaces
{
    public interface IEmployeeRepository
    {
        Task<List<Employee>> GetAll();
        Task<Employee?> GetById(int id);
        Task Add(Employee employee);
        Task Update(Employee employee);
        Task Delete(int id);
    }
}
