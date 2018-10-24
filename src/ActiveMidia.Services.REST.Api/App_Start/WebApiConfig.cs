using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace ActiveMidia.Services.REST.Api {
    public static class WebApiConfig {
        public static void Register(HttpConfiguration config) {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();
            
            config.Routes.MapHttpRoute(
                name: "DefaultApiGetAll",
                routeTemplate: "{controller}/{action}"
                //defaults: new { action = "get" }
            );

            config.Routes.MapHttpRoute(
                name: "DefaultApiGetById",
                routeTemplate: "{controller}/{action}/{id}"
            );

            var appXmlType = config.Formatters.XmlFormatter.SupportedMediaTypes.FirstOrDefault(t => t.MediaType == "application/xml");
            config.Formatters.XmlFormatter.SupportedMediaTypes.Remove(appXmlType);
        }
    }
}
