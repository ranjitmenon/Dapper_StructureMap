using System;
using StructureMap;

namespace EP.INFRASTRUCTURE.DependencyResolver
{
    public static class IoC
    {
        private static Container _container;

        public static IContainer Initialize(Action<ConfigurationExpression> func)
        {
            _container = new Container(func);
            return _container;
        }

        public static IContainer Container()
        {
            return _container;
        }
    }
}