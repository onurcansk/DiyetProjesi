using Entities.Dtos.Users;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class UserCreateValidator:AbstractValidator<UserCreateDTO>
    {
        public UserCreateValidator()
        {
            RuleFor(u => u.BirthDate).Must(CheckAgeIfValid).WithMessage("Kullanıcı 18-25 arasında olmalıdır.");
            RuleFor(u => u.UserName).EmailAddress().WithMessage("Girilen kullanıcı adı mail değil.");
        }

        private bool CheckAgeIfValid(DateTime date)
        {
            int age = DateTime.Now.Year - date.Year;
            return age >= 18 && age <= 25;        
        }
    }
}
