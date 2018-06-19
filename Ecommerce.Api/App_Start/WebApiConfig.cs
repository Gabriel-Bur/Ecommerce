using System.Net.Http.Formatting;
using System.Net.Http.Headers;
using System.Web.Http;

namespace Ecommerce.Api
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Serviços e configuração da API da Web

            // Rotas da API da Web
            config.MapHttpAttributeRoutes();


            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );


            config.EnableQuerySupport();

            GlobalConfiguration.Configuration.Formatters.XmlFormatter.SupportedMediaTypes.Clear();
            
            GlobalConfiguration.Configuration.Formatters.JsonFormatter.MediaTypeMappings.Add(
            new QueryStringMapping("type", "json", new MediaTypeHeaderValue("application/json")));

            GlobalConfiguration.Configuration.Formatters.XmlFormatter.MediaTypeMappings.Add(
            new QueryStringMapping("type", "xml", new MediaTypeHeaderValue("application/xml")));


        }
    }
}
