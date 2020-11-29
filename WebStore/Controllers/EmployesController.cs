using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebStore.Data;
using WebStore.Models;

namespace WebStore.Controllers
{
    public class EmployesController : Controller
    {
        private List<Employee> _employees;

        public EmployesController() => _employees = TestData.Employees;

        public IActionResult Index()
        {
            return View(TestData.Employees);
        }

        public IActionResult Details(int id)
        {
            var employee = _employees.First(x => x.Id == id);
            if (employee != null)
                return View(employee);
            return NotFound();
        }
    }
}
