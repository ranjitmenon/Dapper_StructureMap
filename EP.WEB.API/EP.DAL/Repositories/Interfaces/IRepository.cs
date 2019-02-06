using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EP.DAL.Repositories.Interfaces
{
    public interface IRepository<TEntity> where TEntity : class
    {
        IEnumerable<TEntity> GetList();
        TEntity GetById<TKey>(TKey id);
        int? Create(TEntity entity);
        int Update(TEntity entity);
        int Delete(TEntity entity);
    }
}
