using Base.Entities;

namespace Entities.Concrete
{
    public class Product : IEntity
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public double UnitCalorie { get; set; }
        public int ProductTypeId { get; set; }
        public ProductType ProductType { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
    }

   
}
