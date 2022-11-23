using Entities.Concrete;
using Entities.Dtos.MealDetails;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class MealDetailCreateValidator: AbstractValidator<MealDetailCreateDto>
    {
        public MealDetailCreateValidator()
        {

        }
    }
}
