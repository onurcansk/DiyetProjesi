using Base.Entities;
using Entities.Concrete;

namespace Entities.Dtos.Meal
{
    public class MealCreateDTO : IDto
    {
        public string MealName { get; set; }
    }
}
