using ActiveMidia.Domain.Validation;
using System.Collections.Generic;
using System.Data;

namespace ActiveMidia.Domain.Interfaces.Services.Local.Common
{
    public interface IService<TEntity> where TEntity : class
    {
        IDbConnection GetConnection();
        ValidationResult SaveNew(TEntity entity, IDbTransaction transaction = null, int? commandTimeout = null);
        ValidationResult Update(TEntity entity, IDbTransaction transaction = null, int? commandTimeout = null);
        ValidationResult Delete(TEntity entity, IDbTransaction transaction = null, int? commandTimeout = null);
        TEntity GetById(long id, IDbTransaction transaction = null, int? commandTimeout = null);
        IEnumerable<TEntity> GetAll(IDbTransaction transaction = null, int? commandTimeout = null);
        IEnumerable<TEntity> GetAllWhere(object where = null, object order = null, IDbTransaction transaction = null, int? commandTimeout = null);
    }
}
