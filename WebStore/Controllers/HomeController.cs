using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

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
            return Content(_configuration["ControllerActionText"]);
        }

        public IActionResult SecondAction()
        {
            return Content("Second controller action");
        }
    }
}
