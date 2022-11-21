using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class MealValidator : AbstractValidator<Meal>
    {
        public MealValidator()
        {

        }
    }
}
