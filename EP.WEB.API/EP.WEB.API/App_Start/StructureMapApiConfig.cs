using StructureMap;
using EP.INFRASTRUCTURE.DependencyResolver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EP.SERVICE;
using System.Web.Http;
using System.Web.Http.Dispatcher;

namespace EP.WEB.API
{
    public class StructureMapApiConfig
    {
        public static void Register()
        {
            // Initialize IoC container
            GlobalContainer = IoC.Initialize(c => c.AddRegistry<DefaultRegistry>());

            GlobalConfiguration.Configuration.Services
               .Replace(typeof(IHttpControllerActivator), new StructureMapApiDependencyResolver(GlobalContainer));
        }
        public static IContainer GlobalContainer { get; set; }
       
    }
}