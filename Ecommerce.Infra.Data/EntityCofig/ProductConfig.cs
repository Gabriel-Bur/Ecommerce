using Ecommerce.Domain.Entities;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;

namespace Ecommerce.Infra.Data.EntityCofig
{
    public class ProductConfig : EntityTypeConfiguration<Product>
    {
        public ProductConfig()
        {
            //ID
            HasKey(p => p.Id);



            //ProductCode
            HasIndex(p => p.Code)
                .IsUnique();

            Property(p => p.Code)
                .IsRequired()
                .HasColumnType("varchar")
                .HasMaxLength(5);


            //ProductName      
            Property(p => p.Name)
                .IsRequired()
                .HasColumnType("varchar")
                .HasMaxLength(100);


            //ProductDescription
            Property(p => p.Description)
                .IsRequired()
                .HasColumnType("varchar")
                .HasMaxLength(100);



            //ProductCategory
            Property(p => p.Category)
                .IsRequired()
                .HasColumnType("varchar")
                .HasMaxLength(100);



            //ProductImageURL
            Property(p => p.ImageURL)
                .IsRequired()
                .HasColumnType("varchar")
                .HasMaxLength(2000);



            //ProductPrice
            Property(p => p.Price)
                .IsRequired();


            //ProductBrand
            Property(p => p.Brand)
                .IsRequired()
                .HasColumnType("varchar")
                .HasMaxLength(100);



        }
    }
}
