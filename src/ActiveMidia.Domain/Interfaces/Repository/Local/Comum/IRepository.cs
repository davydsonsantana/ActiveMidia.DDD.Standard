using System.Data;
using System.Collections.Generic;

namespace ActiveMidia.Domain.Interfaces.Repository.ActiveMidia.Comum
{
    public interface IRepository<TEntity> where TEntity : class
    {
        IDbConnection GetConnection();
        dynamic SaveNew(TEntity entity, IDbTransaction transaction = null, int? commandTimeout = null);
        bool Update(TEntity entity, IDbTransaction transaction = null, int? commandTimeout = null);
        bool Delete(TEntity entity, IDbTransaction transaction = null, int? commandTimeout = null);
        TEntity GetById(long id, IDbTransaction transaction = null, int? commandTimeout = null);
        IEnumerable<TEntity> GetAll(IDbTransaction transaction = null, int? commandTimeout = null);
        IEnumerable<TEntity> GetAllWhere(object where = null, object order = null, IDbTransaction transaction = null, int? commandTimeout = null);
        
    }
}
