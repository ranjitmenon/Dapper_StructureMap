using EP.DAL;
using EP.DAL.Repositories;
using EP.DAL.Repositories.Interfaces;
using EP.DAL.Resolvers;
using EP.SERVICE.Interfaces;
using StructureMap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WTW.RAPID.DAL.Resolvers;

namespace EP.SERVICE
{
    public class DefaultRegistry : Registry
    {
        public DefaultRegistry()
        {
            Scan(
                scan =>
                {
                    scan.TheCallingAssembly();
                    scan.WithDefaultConventions();
                    scan.SingleImplementationsOfInterface();
                });

           
            //Services
            //For<ISurveyResponseService>().Use<SurveyResponseService>();
            For<ICustomerService>().Use<CustomerService>();
          


            //Registry for Data Access Layer
            For<IUnitOfWork>().Use<UnitOfWork>();
            For<IRepositoryResolver>().Use<StructureMapResolver>();
            For<IConnectionFactory>().Use<SqlConnectionFactory>().Singleton();

            //Repositories
            For(typeof(IRepository<>)).Use(typeof(GenericRepository<>));
            For<ICustomerRepository>().Use<CustomerRepository>();
        }
    }
}
