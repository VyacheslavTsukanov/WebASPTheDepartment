using ASPTheDepartment.Models;
using ASPTheDepartment.Services;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ASPTheDepartment.Pages.Employees
{
    public class DetailsModel : PageModel
    {
        private readonly IEmployeeRepository _employeeRepository;
        public DetailsModel(IEmployeeRepository emploeeRepository)
        {
            _employeeRepository = emploeeRepository;
        }

        public Employee Employee { get; private set; }

        public void OnGet(int id)
        {
            Employee = _employeeRepository.GetEmployee(id);
        }
    }
}
