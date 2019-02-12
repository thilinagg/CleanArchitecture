using CleanArchitecture.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Core.ServiceContracts
{
    public interface IEmployeeService
    {
        Task<List<Employee>> GetEmployees();
    }
}
