using System;
using System.IO;
using ASPTheDepartment.Models;
using ASPTheDepartment.Services;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;


namespace ASPTheDepartment.Pages
{
    public class EditModel : PageModel
    {

        private readonly IEmployeeRepository _employeeRepository;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public EditModel(IEmployeeRepository employeeRepository, IWebHostEnvironment webHostEnvironment)
        {
            _employeeRepository = employeeRepository;
            _webHostEnvironment = webHostEnvironment;
        }

        public Employee Employee { get; set; }

        [BindProperty]
        public IFormFile Photo { get; set; }

        public IActionResult OnGet(int id)
        {
            Employee = _employeeRepository.GetEmployee(id);

            if (Employee == null)
                return RedirectToPage("/NotFound");

            return Page();
        }

        public IActionResult OnPost(Employee employee)
        {
            if(Photo != null)
            {
                if(employee.PhotoPath != null)
                {
                    string filePath = Path.Combine(_webHostEnvironment.WebRootPath, "images", employee.PhotoPath);
                    System.IO.File.Delete(filePath);
                }

                employee.PhotoPath = ProcessUploadedFile();
            }

            Employee = _employeeRepository.Update(employee);
            return RedirectToPage("Employees");
        }

        private string ProcessUploadedFile()
        {
            string uniqueFileName = null;

            if(Photo != null)
            {
                // Пути к файлу
                string uploadsFolder = Path.Combine(_webHostEnvironment.WebRootPath, "images");
                uniqueFileName = Guid.NewGuid().ToString() + "_" + Photo.FileName;
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);

                // Сохранение на сервер новой фотографии
                using (var fs = new FileStream(filePath, FileMode.Create))
                {
                    Photo.CopyTo(fs);
                };
            }
            return uniqueFileName;
        }
    }
}
