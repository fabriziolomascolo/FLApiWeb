using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

using FLApiWeb.Service;

namespace FLApiWeb
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            //GlobalConfiguration.Configuration.EnsureInitialized();
            //Database.SetInitializer<FLDbContext>(new DropCreateDatabaseIfModelChanges<FLDbContext>());
            ////Model compatibility cannot be checked because the database does not contain model metadata. Model compatibility can only be checked for databases created using Code First or Code First Migrations.
            //Database.SetInitializer<FLDbContext>(new DropCreateDatabaseAlways<FLDbContext>());
            ////CREATE DATABASE permission denied in database 'master
            //Database.SetInitializer<FLDbContext>(new CreateDatabaseIfNotExists<FLDbContext>());
        }
    }
}
