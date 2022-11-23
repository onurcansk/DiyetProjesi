using Entities.Dtos.MealType;
using Entities.Dtos.ProductTypes;
using FluentValidation;
using System.Text.RegularExpressions;

namespace Business.ValidationRules.FluentValidation
{
    public class ProductTypeUpdateValidator : AbstractValidator<ProductTypeUpdateDto>
    {
        public ProductTypeUpdateValidator()
        {
            RuleFor(p => p.ProductTypeName).NotNull().WithMessage("Yemek adı boş olmamalıdır").NotEmpty().WithMessage("Yemek adı boş olmamalıdır")
                                       .MinimumLength(2).WithMessage("Yemek adı en az 2 harften oluşmalıdır.")
                                       .MaximumLength(30).WithMessage("Yemek adı en fazla 30 harften oluşmalıdır.")
                                       .Must(isContainsOnlyLetters).WithMessage("Yemek adı özel karakter veya rakam içermemelidir.");
        }

        private bool isContainsOnlyLetters(string productName)
        {
            return Regex.IsMatch(productName, @"^[a-zA-Z]+$");
        }
    }
}
