using Business.Exceptions;
using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class UserValidator:AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(u => u.BirthDate).Must(CheckAgeIfValid).WithMessage("Kullanıcı 18-25 arasında olmalıdır.");
            RuleFor(u => u.UserName).EmailAddress().WithMessage("Girilen kullanıcı adı mail değil.");
        }

        private bool CheckAgeIfValid(DateTime? date)
        {
            int age = DateTime.Now.Year - date.Value.Year;
            return age >= 18 && age <= 25;        
        }
    }
}
