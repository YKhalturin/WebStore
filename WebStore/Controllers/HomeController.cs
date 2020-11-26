using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using WebStore.Models;

namespace WebStore.Controllers
{
    public class HomeController : Controller
    {
        private IConfiguration _configuration;

        private static readonly List<Employee> Employees = new List<Employee>
        {
            new Employee() {Id = 1, LastName = "Иванов", FirstName = "Иван", Patronymic = "Иванович", Age = 32},
            new Employee() {Id = 2, LastName = "Петров", FirstName = "Петр", Patronymic = "Петрович", Age = 22},
            new Employee() {Id = 3, LastName = "Сидоров", FirstName = "Сидор", Patronymic = "Сидорович", Age = 42},
        };

        public HomeController( IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public IActionResult Index()
        {
            return View();
            //return Content(_configuration["ControllerActionText"]);
        }

        public IActionResult SecondAction()
        {
            return Content("Second controller action");
        }

        public IActionResult Employes()
        {
            return View(Employees);
        }
    }
}
