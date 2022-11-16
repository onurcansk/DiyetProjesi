using Base.Entities;

namespace Entities.Concrete
{
    public class Meal : IEntity
    {
        public int Id { get; set; }
        public int MealTypeID { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public virtual MealType MealType { get; set; }
        public int MealDetailsID { get; set; }
        public virtual ICollection<MealDetail> MealDetails { get; set; }
        public Meal()
        {
            MealDetails = new HashSet<MealDetail>();
        }

    }

   
}
