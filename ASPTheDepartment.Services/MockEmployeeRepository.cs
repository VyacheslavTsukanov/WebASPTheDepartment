using ASPTheDepartment.Models;
using System;
using System.Collections.Generic;
using System.Text;

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
                    Id = 1, Name = "Slava", Email = "slava@example.com", PhotoPath = "avatar.png", Department = Dept.IT
                },
                new Employee()
                {
                    Id = 2, Name = "Slava", Email = "slava@example.com", PhotoPath = "avatar2.png", Department = Dept.IT
                },
                 new Employee()
                {
                    Id = 3, Name = "Shawn", Email = "Shawn@example.com", PhotoPath = "avatar.png", Department = Dept.Payroll
                },
                new Employee()
                {
                    Id = 4, Name = "Jenifer", Email = "Jenifer@example.com", PhotoPath = "avatar2.png", Department = Dept.HR
                },
                 new Employee()
                {
                    Id = 0, Name = "Stem", Email = "Stem@example.com", Department = Dept.IT
                }
            };
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            return _employeeList;
        }
    }
}
