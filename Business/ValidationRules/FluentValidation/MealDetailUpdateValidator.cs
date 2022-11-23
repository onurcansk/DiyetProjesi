using Entities.Dtos.MealDetails;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class MealDetailUpdateValidator : AbstractValidator<MealDetailUpdateDto>
    {
        public MealDetailUpdateValidator()
        {

        }
    }
}
