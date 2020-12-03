using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebStore.Data;
using WebStore.Models;

namespace WebStore.Controllers
{
    //[Route("Users")]
    public class EmployesController : Controller
    {
        private List<Employee> _employees;

        public EmployesController() => _employees = TestData.Employees;

        //[Route("All")]
        public IActionResult Index()
        {
            return View(TestData.Employees);
        }

        //[Route("Info(id-{id})")]
        public IActionResult Details(int id)
        {
            var employee = _employees.First(x => x.Id == id);
            if (employee != null)
                return View(employee);
            return NotFound();
        }
    }
}
