using Entities.Dtos.Product;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class ProductCreateValidator: AbstractValidator<ProductCreateDTO>
    {
        public ProductCreateValidator()
        {

        }
    }
}
