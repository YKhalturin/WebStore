using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using WebStore.Data;
using WebStore.Models;

namespace WebStore.Controllers
{
    public class HomeController : Controller
    {
        private IConfiguration _configuration;

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
            return View(TestData.Employees);
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
