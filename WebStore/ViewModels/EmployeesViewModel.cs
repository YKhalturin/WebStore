using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebStore.ViewModels
{
    public class EmployeesViewModel : IValidatableObject
    {
        [HiddenInput(DisplayValue = false)]
        public int Id { get; set; }
        
        [Display(Name = "Имя")]
        [Required(ErrorMessage = "Имя является обязательным")]
        [StringLength(15, MinimumLength = 2, ErrorMessage = "Длина имени должна быть от 2 до 15 символов")]
        [RegularExpression(@"([А-ЯЁ][а-яё]+)|([A-Z][a-z]+)", ErrorMessage = "Ошибка формата имени")]
        public string FirstName { get; set; }
        
        [Display(Name = "Фамилия")]
        [Required(ErrorMessage = "Фамилия является обязательным")]
        [StringLength(15, MinimumLength = 3, ErrorMessage = "Длина фамилии должна быть от 3 до 15 символов")]
        public string LastName { get; set; }
        
        [Display(Name = "Отчество")]
        public string Patronymic { get; set; }
        
        [Display(Name = "Возраст")]
        [Range(18, 80, ErrorMessage = "Сотрудники должны быть в возрасте от 18 до 80 лет")]
        public int Age { get; set; }
        public DateTime BirthDay { get; set; }
        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            yield return ValidationResult.Success;
        }
    }
}
