using Entities.Concrete;
using Entities.Dtos.Meal;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class MealCreateValidator : AbstractValidator<MealCreateDTO>
    {
        public MealCreateValidator()
        {

        }
    }
}
