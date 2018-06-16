using Ecommerce.Domain.Entities;
using Ecommerce.Infra.Data.EntityCofig;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Infra.Data.Context
{

    public class EcommerceContext : DbContext
    {
        public EcommerceContext() 
            : base("EcommerceDefaultConnection")
        {
        }

        public DbSet<Product> Products { get; set; }



        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBuilder.Configurations.Add(new ProductConfig());

        }
    }
}
