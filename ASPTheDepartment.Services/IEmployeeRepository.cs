using ASPTheDepartment.Models;
using System.Collections.Generic;

namespace ASPTheDepartment.Services
{
    public interface IEmployeeRepository
    {
        IEnumerable<Employee> GetAllEmployees();
        Employee GetEmployee(int id);
        Employee Update(Employee updateEmployee);
    }
}
