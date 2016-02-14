using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Http;
using LightInject;
using Tasks.Repositories.Contacts;
using Tasks.Repositories;
using Tasks.Models;
using System.Data.Entity;

namespace Tasks
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            var container = new ServiceContainer();
            container.RegisterApiControllers();

            container.Register<DbContext, TasksEntities>();
            container.Register<ITasksRepository, TasksRepository>(new PerScopeLifetime());
            container.Register<ITaskStatusesRepository, TaskStatusesRepository>(new PerScopeLifetime());
            container.Register<ITaskTypesRepository, TaskTypesRepository>(new PerScopeLifetime());

            container.EnablePerWebRequestScope();
            container.EnableWebApi(GlobalConfiguration.Configuration);
        }
    }
}
