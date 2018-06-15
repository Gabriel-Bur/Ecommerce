using Ecommerce.Domain.Entities;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ecommerce.Infra.Data.EntityCofig
{
    public class ProductConfig : EntityTypeConfiguration<Product>
    {
        public ProductConfig()
        {
            //ID
            HasKey(p => p.Id);



            //ProductCode
            Property(p => p.ProductCode)
                .IsRequired()
                .HasColumnType("varchar")
                .HasMaxLength(10);


            //ProductName      
            HasIndex(p => p.ProductName)
                .IsUnique();

            Property(p => p.ProductName)
                .IsRequired()
                .HasColumnType("varchar")
                .HasMaxLength(100);


            //ProductDescription
            Property(p => p.ProductDescription)
                .IsRequired()
                .HasColumnType("varchar")
                .HasMaxLength(100);



            //ProductCategory
            Property(p => p.ProductCategory)
                .IsRequired()
                .HasColumnType("varchar")
                .HasMaxLength(100);



            //ProductImageURL
            Property(p => p.ProductImageURL)
                .IsRequired()
                .HasColumnType("varchar")
                .HasMaxLength(2000);



            //ProductPrice
            Property(p => p.ProductPrice)
                .IsRequired();


            //ProductBrand
            Property(p => p.ProductBrand)
                .IsRequired()
                .HasColumnType("varchar")
                .HasMaxLength(100);



        }
    }
}
