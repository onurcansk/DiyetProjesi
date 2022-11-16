using Base.Entities;

namespace Entities.Concrete
{
    public class MealDetail:IEntity
    {
        public int Id { get; set; }
        public double Gram { get; set; }

        public int MealId { get; set; }
        public Meal Meal { get; set; }
       
        public int ProductId { get; set; }
        public Product Product { get; set; }
       

        public User User { get; set; }
        public string UserName { get; set; }
        public DateTime MealDate { get; set; }

       
    }

   
}
