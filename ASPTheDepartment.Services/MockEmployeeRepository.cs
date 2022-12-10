using ASPTheDepartment.Models;
using System.Collections.Generic;
using System.Linq;

namespace ASPTheDepartment.Services
{
    public class MockEmployeeRepository : IEmployeeRepository
    {
        private List<Employee> _employeeList;
        public MockEmployeeRepository()
        {
            _employeeList = new List<Employee>()
            {
                new Employee()
                {
                    Id = 0, Name = "Mark", Email = "mark@example.com", PhotoPath = "avatar2.png", Department = Dept.HR
                },
                new Employee()
                {
                    Id = 1, Name = "Slava", Email = "slava@example.com", PhotoPath = "avatar2.png", Department = Dept.IT
                },
                new Employee()
                {
                    Id = 2, Name = "Stiven", Email = "stiven@example.com", PhotoPath = "avatar2.png", Department = Dept.IT
                },
                 new Employee()
                {
                    Id = 3, Name = "Shawn", Email = "shawn@example.com", PhotoPath = "avatar2.png", Department = Dept.Payroll
                },
                new Employee()
                {
                    Id = 4, Name = "Jenifer", Email = "jenifer@example.com", PhotoPath = "avatar3.png", Department = Dept.HR
                },
                 new Employee()
                {
                    Id = 5, Name = "Sten", Email = "sten@example.com", Department = Dept.IT
                }
            };
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            return _employeeList;
        }

        public Employee GetEmployee(int id)
        {
            return _employeeList.FirstOrDefault(x => x.Id == id);
        }

        public Employee Update(Employee updateEmployee)
        {
            Employee employee = _employeeList.FirstOrDefault(x => x.Id == updateEmployee.Id);

            if(employee != null)
            {
                employee.Name = updateEmployee.Name;
                employee.Email = updateEmployee.Email;
                employee.Department = updateEmployee.Department;
                employee.PhotoPath = updateEmployee.PhotoPath;
            }

            return employee;
        }
    }
}
