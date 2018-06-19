using AutoMapper;
using Ecommerce.Api.Models;
using Ecommerce.Application.Interface;
using Ecommerce.Domain.Entities;
using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.OData.Query;

namespace Ecommerce.Api.Controllers
{
 
    
    [RoutePrefix("api/products")]
    public class ProductsController : ApiController
    {

        private readonly IProductAppService _productApp;

        public ProductsController(IProductAppService productApp)
        {
            _productApp = productApp;
        }

        [HttpGet]
        [Queryable(AllowedQueryOptions=AllowedQueryOptions.Filter)]
        [Route("page/{id:int=0}")]
        public IHttpActionResult GetPaged(int id)
        {
            var products = Mapper.Map<IEnumerable<Product>, IEnumerable<ModelProduct>>(_productApp.GetPaged(id));

            return Ok(products);
        }


        [Queryable(AllowedQueryOptions = AllowedQueryOptions.Filter)]
        // GET: api/Products
        public IHttpActionResult GetAll()
        {
            var products = Mapper.Map<IEnumerable<Product>, IEnumerable<ModelProduct>>(_productApp.GetAll());
            return Ok(products);
        }


        [HttpGet]
        [Route("{id:int}")]
        // GET: api/Products/5
        public IHttpActionResult Get(int id)
        {
            var product = Mapper.Map<Product, ModelProduct>(_productApp.GetById(id));

            if (product == null)
            {
                return NotFound();
            }

            return Ok(product);

        }



        [HttpPost]
        // POST: api/Products
        public IHttpActionResult Post(ModelProduct product)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var productToAdd = Mapper.Map<ModelProduct, Product>(product);
                    _productApp.Add(productToAdd);


                    return Ok(productToAdd);
                }
                catch
                {
                    return InternalServerError();
                }

            }
            else
            {
                return BadRequest(ModelState);
            }
        }



        [Route("{id:int}")]
        // PUT: api/Products/5
        public IHttpActionResult Put(int id, ModelProduct product)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var productToUpdate = Mapper.Map<ModelProduct, Product>(product);
                    _productApp.Update(productToUpdate);


                    return Ok(productToUpdate);
                }
                catch
                {
                    return InternalServerError();
                }

            }
            else
            {
                return BadRequest(ModelState);
            }

        }



        [HttpDelete]
        [Route("{id:int}")]
        // DELETE: api/Products/5
        public IHttpActionResult Delete(int id)
        {

            var product = _productApp.GetById(id);

            if (product == null)
            {
                return NotFound();
            }

            _productApp.Remove(product);

            return Ok(product);

        }

    }
}
