
using EP.DAL;
using EP.DAL.Repositories.Interfaces;

namespace WTW.RAPID.DAL.Resolvers
{
    public interface IRepositoryResolver
    {
        TRepository GetRegisteredRepository<TRepository>(IUnitOfWork unitOfWork) where TRepository : class;
        IRepository<TEntity> GetRepositoryForEntity<TEntity>(IUnitOfWork unitOfWork) where TEntity : class, new();
    }
}