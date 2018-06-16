using AutoMapper;
using Ecommerce.Api.Models;
using Ecommerce.Domain.Entities;
using System.Web.Http;


namespace Ecommerce.Api
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);

            Mapper.Initialize(x =>
            {
                x.CreateMap<Product, ModelProduct>();
                x.CreateMap<ModelProduct, Product>();
            });

            
        }
    }
}
