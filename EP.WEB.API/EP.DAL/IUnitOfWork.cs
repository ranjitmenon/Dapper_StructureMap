using EP.DAL.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EP.DAL
{
    public interface IUnitOfWork : IDisposable
    {
        IDbTransaction DbTransaction { get; }
        IDbConnection GetConnection();
        TRepository GetRegisteredRepository<TRepository>() where TRepository : class;
        IRepository<TEntity> GetGenericRepositoryForEntity<TEntity>() where TEntity : class, new();
        void Commit();
        void Rollback();

        void ManageTransaction(Action action);
        void BeginTransaction();

    }
}
