using System.Collections.Generic;
using Ecommerce.Application.Interface;
using Ecommerce.Domain.Entities;
using Ecommerce.Domain.Interfaces.Services;

namespace Ecommerce.Application
{
    public class ProductAppService : AppServiceBase<Product>,IProductAppService
    {
        private readonly IProductService _productService;


        public ProductAppService(IProductService productService)
            : base(productService)
        {
            _productService = productService;
        }

        public IEnumerable<Product> GetPaged(int id)
        {
           return _productService.GetPaged(id);
        }
    }
}
