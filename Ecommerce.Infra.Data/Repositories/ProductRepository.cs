using Ecommerce.Domain.Entities;
using Ecommerce.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Infra.Data.Repositories
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
    }
}
