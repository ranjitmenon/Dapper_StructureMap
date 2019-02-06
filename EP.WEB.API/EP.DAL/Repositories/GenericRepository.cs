using EP.DAL.Repositories.Interfaces;
using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleCRUD = DapperExtension.SimpleCRUD;

namespace EP.DAL.Repositories
{
    public class GenericRepository<TEntity> : IRepository<TEntity> where TEntity : class
    {

        private readonly IUnitOfWork _uof;
        public GenericRepository(IUnitOfWork uof)
        {
            _uof = uof;
        }

        public int? Create(TEntity entity)
        {
            return SimpleCRUD.Insert(_uof.GetConnection(),_uof.DbTransaction);
        }

        public int Delete(TEntity entity)
        {
            return SimpleCRUD.Delete<TEntity>(_uof.GetConnection(),_uof.DbTransaction);
        }

        public TEntity GetById<TKey>(TKey id)
        {
            return SimpleCRUD.Get<TEntity>(_uof.GetConnection(), _uof.DbTransaction);
        }

        public IEnumerable<TEntity> GetList()
        {
            return SimpleCRUD.GetList<TEntity>(_uof.GetConnection(), null);
        }

        public int Update(TEntity entity)
        {
            return SimpleCRUD.Update(_uof.GetConnection(), _uof.DbTransaction);
        }
    }
}
