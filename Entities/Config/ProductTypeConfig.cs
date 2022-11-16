using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Entities.Config
{
    public class ProductTypeConfig : IEntityTypeConfiguration<ProductType>
    {
        public void Configure(EntityTypeBuilder<ProductType> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.ProductTypeName).IsRequired(true).HasMaxLength(20);
            builder.HasData(
               new ProductType{Id=1, ProductTypeName="Meat" },
               new ProductType{Id=2, ProductTypeName="Fish" },
               new ProductType{Id=3, ProductTypeName="Staple Food" },
               new ProductType{Id=4, ProductTypeName="Vegetable" },
               new ProductType{Id=5, ProductTypeName="Fruit" }
                
                
                
                );

        }
    }


}
