using StructureMap;
using EP.DAL.Repositories.Interfaces;
using WTW.RAPID.DAL.Resolvers;

namespace EP.DAL.Resolvers
{
    public class StructureMapResolver : IRepositoryResolver
    {
        private readonly IContainer _container;

        public StructureMapResolver(IContainer container)
        {
            _container = container;
        }

        public TRepository GetRegisteredRepository<TRepository>(IUnitOfWork unitOfWork) where TRepository : class
        {
            return _container.With(x => x.With(unitOfWork)).GetInstance<TRepository>();
        }

        public IRepository<TEntity> GetRepositoryForEntity<TEntity>(IUnitOfWork unitOfWork) where TEntity : class, new()
        {
            return _container.With(x => x.With(unitOfWork)).GetInstance<IRepository<TEntity>>();
        }
    }
}