using Base.Entities;

namespace Entities.Concrete
{
    public class Meal : IEntity
    {
        public int Id { get; set; }
        public MealType MealName { get; set; }
        public ICollection<MealDetail> MealDetails { get; set; }

        public Meal()
        {
            MealDetails = new List<MealDetail>();
        }
    }

   
}
