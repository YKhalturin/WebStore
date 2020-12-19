using Microsoft.AspNetCore.Mvc;
using System;
using Microsoft.AspNetCore.Authorization;
using WebStore.Domain.Entities.Identity;
using WebStore.Infrastructure.Interfaces;
using WebStore.Models;
using WebStore.ViewModels;

namespace WebStore.Controllers
{
    //[Route("Users")]
    [Authorize]
    public class EmployesController : Controller
    {
        private IEmployeesData _employees;

        public EmployesController(IEmployeesData Employees) => _employees = Employees;

        //[Route("All")]
        public IActionResult Index()
        {
            var employees = _employees.Get();
            return View(employees);
        }

        //[Route("Info(id-{id})")]
        public IActionResult Details(int id)
        {
            var employee = _employees.Get(id);
            if (employee != null)
                return View(employee);
            return NotFound();
        }

        [Authorize (Roles = Role.Administrator)]
        public IActionResult Create() => View("Edit", new EmployeesViewModel());


        [Authorize(Roles = Role.Administrator)]
        public IActionResult Edit(int? id)
        {
            if (id is null)
                return View(new EmployeesViewModel());

            if (id < 0)
                return BadRequest();

            var employee = _employees.Get((int)id);
            if (employee is null)
                return NotFound();

            return View(new EmployeesViewModel
            {
                Id = employee.Id,
                LastName = employee.LastName,
                FirstName = employee.FirstName,
                Patronymic = employee.Patronymic,
                Age = employee.Age,
            });
        }

        [HttpPost]
        [Authorize(Roles = Role.Administrator)]
        public IActionResult Edit(EmployeesViewModel Model)
        {
            if (Model.Age == 25)
                ModelState.AddModelError("Age", "Возраст не должен быть равен 25");

            if (Model.LastName == "Иванов" && Model.Age == 30)
                ModelState.AddModelError("", "Странный человек...");

            if (!ModelState.IsValid) return View(Model);

            if (Model is null)
                throw new ArgumentNullException(nameof(Model));

            var employee = new Employee
            {
                Id = Model.Id,
                LastName = Model.LastName,
                FirstName = Model.FirstName,
                Patronymic = Model.Patronymic,
                Age = Model.Age,
            };

            if (employee.Id == 0)
                _employees.Add(employee);
            else
                _employees.Update(employee);

            return RedirectToAction("Index");
        }

        [Authorize(Roles = Role.Administrator)]
        public IActionResult Delete(int id)
        {
            if (id <= 0)
                return BadRequest();

            var employee = _employees.Get(id);
            if (employee is null)
                return NotFound();

            return View(new EmployeesViewModel
            {
                Id = employee.Id,
                LastName = employee.LastName,
                FirstName = employee.FirstName,
                Patronymic = employee.Patronymic,
                Age = employee.Age,
            });
        }

        [HttpPost]
        [Authorize(Roles = Role.Administrator)]
        public IActionResult DeleteConfirmed(int id)
        {
            _employees.Delete(id);
            return RedirectToAction("Index");
        }



    }
}
