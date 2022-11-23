using Entities.Dtos.MealType;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class ProductTypeUpdateValidator : AbstractValidator<MealTypeUpdateDto>
    {
        public ProductTypeUpdateValidator()
        {

        }
    }
}
