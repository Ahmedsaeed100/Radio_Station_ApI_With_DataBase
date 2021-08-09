using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Cors;

namespace API
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
            config.EnableCors();
            // Web API routes

            EnableCorsAttribute Cors = new EnableCorsAttribute("*", "*", "*");
            config.EnableCors(Cors);


            config.Formatters.Remove(config.Formatters.XmlFormatter);
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                  name: "ActionNameWithParam",
                  routeTemplate: "api/{controller}/{action}/{id}",
         defaults: new { id = RouteParameter.Optional }
     );

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
            config.Routes.MapHttpRoute(
               name: "ActionName",
               routeTemplate: "api/{controller}/{action}"
           );


        }
    }
}

