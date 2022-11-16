using Base.Entities;

namespace Entities.Concrete
{
    public class ProductType : IEntity
    {
        public int Id { get; set; }
        public string ProductTypeName { get; set; }
    }

   
}
