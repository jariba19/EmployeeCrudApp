using CrudApp.Domain.Interfaces;
using CrudApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudApp.Services.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeeService(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public async Task<List<Employee>> GetEmployees()
        {
            return await _employeeRepository.GetAll();
        }

        public async Task AddEmployee(Employee p)
        {
            await _employeeRepository.Add(p);
        }

        public async Task<Employee?> GetEmployeeById(int id)
        {
            return await _employeeRepository.GetById(id);
        }

        public async Task UpdateEmployee(Employee employee)
        {
            await _employeeRepository.Update(employee);
        }

        public async Task DeleteEmployee(int id)
        {
            await _employeeRepository.Delete(id);
        }

    }
}
