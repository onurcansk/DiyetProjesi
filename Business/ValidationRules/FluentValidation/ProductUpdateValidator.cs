using Entities.Concrete;
using Entities.Dtos.Product;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class ProductUpdateValidator : AbstractValidator<ProductUpdateDTO>
    {
        public ProductUpdateValidator()
        {

        }
    }
}
