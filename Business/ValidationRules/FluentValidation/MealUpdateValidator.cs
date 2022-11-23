using Entities.Dtos.Meal;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class MealUpdateValidator : AbstractValidator<MealUpdateDTO>
    {
        public MealUpdateValidator()
        {

        }
    }
}
