using System;
using System.IO;
using System.Linq;
using System.Net.Http.Formatting;
using System.Reflection;
using System.Web.Http;
using Newtonsoft.Json.Serialization;
using Owin;
using Swashbuckle.Application;

namespace WebApplication3
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            var config = new HttpConfiguration();
            config.MapHttpAttributeRoutes();
            config.Routes.MapHttpRoute("DefaultApi", "{Controller}");
            config.EnableCors();

            config
                .EnableSwagger(c =>
                {
                    var baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
                    var path = Path.Combine(baseDirectory, "bin/WebApplication3.xml");

                    c.SingleApiVersion("v1", Assembly.GetExecutingAssembly().GetName().Name);
                    c.IncludeXmlComments(path);
                })
                .EnableSwaggerUi();

            // JSON should serialize to camelCase, not PascalCase (the default)
            var jsonFormatter = config.Formatters.OfType<JsonMediaTypeFormatter>().First();
            jsonFormatter.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();

            app.UseWebApi(config);
        }
    }
}