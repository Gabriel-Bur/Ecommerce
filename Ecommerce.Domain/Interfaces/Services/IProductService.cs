using Ecommerce.Domain.Entities;
using System.Collections.Generic;

namespace Ecommerce.Domain.Interfaces.Services
{
    public interface IProductService : IServiceBase<Product>
    {
        IEnumerable<Product> GetPaged(int id);
    }
}
