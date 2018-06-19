using System.Collections.Generic;
using System.Linq;
using Ecommerce.Domain.Entities;
using Ecommerce.Domain.Interfaces.Repositories;

namespace Ecommerce.Infra.Data.Repositories
{
    public class ProductRepository : RepositoryBase<Product>, IProductRepository
    {
        public IEnumerable<Product> GetPaged(int id)
        {
            const int ContentPerPage = 4;
            var queryResult = db.Products
                .AsQueryable()
                .OrderBy(p=>p.Id)
                .Skip(ContentPerPage * id)
                .Take(ContentPerPage)
                .ToList();

            return queryResult;
        }
    }
}
