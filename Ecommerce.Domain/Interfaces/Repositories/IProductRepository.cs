using Ecommerce.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Domain.Interfaces.Repositories
{
    public interface IProductRepository : IRespositoryBase<Product>
    {
        IEnumerable<Product> GetPaged(int id);
    }
}
