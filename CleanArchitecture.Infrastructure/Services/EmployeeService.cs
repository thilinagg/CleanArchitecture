using CleanArchitecture.Core.Entities;
using CleanArchitecture.Core.ServiceContracts;
using CleanArchitecture.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Infrastructure.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly AppDbContext _context;
        public EmployeeService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<Employee>> GetEmployees()
        {
            var employeeList = await _context.Employees.ToListAsync();
            return employeeList;
        }
    }
}
