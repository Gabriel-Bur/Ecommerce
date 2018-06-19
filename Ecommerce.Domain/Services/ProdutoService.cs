using Ecommerce.Domain.Entities;
using Ecommerce.Domain.Interfaces.Repositories;
using Ecommerce.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Domain.Services
{
    public class ProductService: ServiceBase<Product>,IProductService
    {

        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
            :base(productRepository)
        {
            _productRepository = productRepository;
        }

        public IEnumerable<Product> GetPaged(int id)
        {
            return _productRepository.GetPaged(id);
        }
    }
}
