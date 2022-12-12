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

        [BindProperty]
        public Employee Employee { get; set; }

        [BindProperty]
        public IFormFile Photo { get; set; }

        [BindProperty]
        public bool Notify { get; set; }
        public string Massage { get; set; }

        public IActionResult OnGet(int? id)
        {
            if(id.HasValue)
                Employee = _employeeRepository.GetEmployee(id.Value);
            else
                Employee = new Employee();
            

            if (Employee == null)
                return RedirectToPage("/NotFound");

            return Page();
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                if (Photo != null)
                {
                    if (Employee.PhotoPath != null)
                    {
                        string filePath = Path.Combine(_webHostEnvironment.WebRootPath, "images", Employee.PhotoPath);
                        System.IO.File.Delete(filePath);
                    }

                    Employee.PhotoPath = ProcessUploadedFile();
                }

                if(Employee.Id > 0)
                {
                    Employee = _employeeRepository.Update(Employee);
                    TempData["SeccessMessage"] = $"Update {Employee.Name} successful!";
                }
                else
                {
                    Employee = _employeeRepository.Add(Employee);
                    TempData["SeccessMessage"] = $"Adding {Employee.Name} successful!";
                }
                
                return RedirectToPage("Employees");
            }

            return Page();
           
        }

        public void OnPostUpdateNotificationPreferences(int id)
        {
            if (Notify)
            {
                Massage = "Thank you for turning on the notification";
            }
            else
            {
                Massage = "Your have turned off email notifications";
            }

            Employee = _employeeRepository.GetEmployee(id);
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
