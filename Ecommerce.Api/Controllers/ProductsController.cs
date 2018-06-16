using AutoMapper;
using Ecommerce.Api.Models;
using Ecommerce.Domain.Entities;
using Ecommerce.Infra.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Ecommerce.Api.Controllers
{
    public class ProductsController : ApiController
    {

        private readonly ProductRepository _product = new ProductRepository();

        // GET: api/Products
        public IHttpActionResult Get()
        {
            var products = Mapper.Map<IEnumerable<Product>, IEnumerable<ModelProduct>>(_product.GetAll());
            return Ok(products);
        }

        // GET: api/Products/5
        public IHttpActionResult Get(int id)
        {
            var product = Mapper.Map<Product, ModelProduct>(_product.GetById(id));

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
                    _product.Add(productToAdd);


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

        // PUT: api/Products/5
        public void Put(int id, [FromBody]string value)
        {

            //to do

        }

        // DELETE: api/Products/5
        public void Delete(int id)
        {

            //to do

        }
    }
}
