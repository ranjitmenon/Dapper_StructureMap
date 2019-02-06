using System;
using System.Net.Http;
using System.Web.Http.Controllers;
using System.Web.Http.Dispatcher;
using StructureMap;

namespace EP.INFRASTRUCTURE.DependencyResolver
{
    public class StructureMapApiDependencyResolver : IHttpControllerActivator
    {
        private readonly IContainer _container;

        public StructureMapApiDependencyResolver(IContainer container)
        {
            _container = container;
        }

        public IHttpController Create(HttpRequestMessage request, HttpControllerDescriptor controllerDescriptor, Type controllerType)
        {
            var controller = _container.GetInstance(controllerType) as IHttpController;
            return controller;
        }
    }
}