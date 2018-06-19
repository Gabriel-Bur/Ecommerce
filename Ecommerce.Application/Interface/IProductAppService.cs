using Ecommerce.Domain.Entities;
using System.Collections.Generic;

namespace Ecommerce.Application.Interface
{
    public interface IProductAppService: IAppServiceBase<Product>
    {
        IEnumerable<Product> GetPaged(int id);
    }
}
