using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebStore.Models;

namespace WebStore.Data
{
    public static class TestData
    {
        public static List<Employee> Employees { get; } = new List<Employee>
        {
            new Employee()
            {
                Id = 1, LastName = "Иванов", FirstName = "Иван", Patronymic = "Иванович", Age = 30,
                BirthDay = new DateTime(1990, 12, 11)
            },
            new Employee()
            {
                Id = 2, LastName = "Петров", FirstName = "Петр", Patronymic = "Петрович", Age = 20,
                BirthDay = new DateTime(2000, 4, 2)
            },
            new Employee()
            {
                Id = 3, LastName = "Сидоров", FirstName = "Сидор", Patronymic = "Сидорович", Age = 40,
                BirthDay = new DateTime(1980, 4, 4)
            },
        };
    }
}
