using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EP.DAL.Repositories.Interfaces;
using WTW.RAPID.DAL.Resolvers;

namespace EP.DAL
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IConnectionFactory _connectionFactory;
        private readonly IRepositoryResolver _repositoryResolver;

        public IDbConnection DbConnection { get; set; }
        public IDbTransaction DbTransaction { get; private set; }

        public UnitOfWork(IConnectionFactory connectionFactory, IRepositoryResolver repositoryResolver)
        {
            _connectionFactory = connectionFactory;
            _repositoryResolver = repositoryResolver;
        }

        public void BeginTransaction()
        {
            GetConnection();
            if (DbTransaction != null) return;
            DbTransaction = DbConnection.BeginTransaction();
        }

        public void Commit()
        {
            try
            {
                DbTransaction?.Commit();
            }
            catch
            {
                Rollback();
            }
        }

        public void Dispose()
        {
            Debug.WriteLine("UnitOfWork Dispose() called.");
            DbTransaction?.Dispose();
            DbConnection?.Dispose();

            DbTransaction = null;
            DbConnection = null;
        }

        public IDbConnection GetConnection()
        {
            if (DbConnection != null) return DbConnection;

            DbConnection = _connectionFactory.GetConnection();
            DbConnection.Open();
            return DbConnection;
        }

        public IRepository<TEntity> GetGenericRepositoryForEntity<TEntity>() where TEntity : class, new()
        {
            return _repositoryResolver.GetRepositoryForEntity<TEntity>(this);
        }

      
        public TRepository GetRegisteredRepository<TRepository>() where TRepository : class
        {
            return _repositoryResolver.GetRegisteredRepository<TRepository>(this);
        }

        public void ManageTransaction(Action action)
        {
            var outerTxStarted = DbTransaction != null;
            if (!outerTxStarted) BeginTransaction();
            action();
            if (!outerTxStarted) Commit();
        }

        public void Rollback()
        {
            DbTransaction?.Rollback();
        }
    }
}
