using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Web.Http;
using System.Web.Http.Cors;
using FLApiWeb.Models;
using FLApiWeb.Service;
using Unity;
using Newtonsoft.Json.Serialization;

namespace FLApiWeb
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            var cors = new EnableCorsAttribute("*", "*", "*");
            config.EnableCors(cors);
            

            // Web API configuration and services
            config.Formatters.JsonFormatter.SupportedMediaTypes.Add(new MediaTypeHeaderValue("text/html"));

            config.Formatters.JsonFormatter.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
            config.Formatters.JsonFormatter.UseDataContractJsonSerializer = false;

            // Web API routes
            config.MapHttpAttributeRoutes();

            //config.Routes.MapHttpRoute(
            //    name: "DefaultApi",
            //    routeTemplate: "api/{controller}/{id}",
            //    defaults: new { id = RouteParameter.Optional }
            //);
            //config.Routes.MapHttpRoute(
            //    name: "GetUsername",
            //    routeTemplate: "api/auth/{username}",
            //    defaults: new { id = RouteParameter.Optional }
            //);

            var container = new UnityContainer();
            container.RegisterType<ITerapieRepository, TerapieRepository>();
            container.RegisterType<IPatologieRepository, PatologieRepository>();
            config.DependencyResolver = new UnityResolver(container);
        }
    }
}
