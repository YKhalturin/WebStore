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

        public static readonly List<Employee> Employees = new List<Employee>
        {
            new Employee() {Id = 1, LastName = "Иванов", FirstName = "Иван", Patronymic = "Иванович", Age = 30, BirthDay = new DateTime(1990,12,11)},
            new Employee() {Id = 2, LastName = "Петров", FirstName = "Петр", Patronymic = "Петрович", Age = 20, BirthDay = new DateTime(2000,4,2)},
            new Employee() {Id = 3, LastName = "Сидоров", FirstName = "Сидор", Patronymic = "Сидорович", Age = 40, BirthDay = new DateTime(1980,4,4)},
        };

        public HomeController( IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult SecondAction()
        {
            return Content("Second controller action");
        }

        public IActionResult Employes()
        {
            return View(Employees);
        }

        public IActionResult Details(int id)
        {
            return View(Employees.First(x => x.Id == id));
        }

        public IActionResult Blogs() => View();
        public IActionResult BlogSingle() => View();
        public IActionResult Cart() => View();
        public IActionResult CheckOut() => View();
        public IActionResult ContactUs() => View();
        public IActionResult Login() => View();
        public IActionResult ProductDetails() => View();
        public IActionResult Shop() => View();


    }
}
