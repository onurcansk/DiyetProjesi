using Base.Entities;

namespace Entities.Concrete
{
    public class MealDetail:IEntity
    {
        public int Id { get; set; }
        public double Gram { get; set; }
        public int MealID { get; set; }
        public virtual Meal Meal { get; set; }
        public int ProductId { get; set; }
        public virtual Product Products { get; set; }
        public string UserName { get; set; }
        public virtual User User { get; set; }
        public DateTime? MealDate { get; set; }

       
    }

   
}
