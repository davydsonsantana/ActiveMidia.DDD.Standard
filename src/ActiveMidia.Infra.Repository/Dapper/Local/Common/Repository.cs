using System;
using System.Collections.Generic;
using System.Data;
using DapperExtensions;
using ActiveMidia.Domain.Interfaces.Repository.ActiveMidia.Comum;
using DapperExtensions.Sql;
using ActiveMidia.Infra.Context.Interfaces;
using ActiveMidia.Infra.Context.Mapeamento;

namespace ActiveMidia.Infra.Repository.Dapper.Common {
    public class Repository<TEntity> : IRepository<TEntity>, IDisposable where TEntity : class {

        public IDbConnection Connection { get; set; }

        public Repository(IDapperContext context) {
            Connection = context.Connection;
            InicializaMapperDapper();
        }

        public IDbConnection GetConnection() {
            return Connection;
        }

        public static void InicializaMapperDapper() {
            DapperExtensions.DapperExtensions.SetMappingAssemblies(new[] { typeof(AccountMapper).Assembly });
            DapperExtensions.DapperExtensions.SqlDialect = new MySqlDialect();
        }

        public dynamic SaveNew(TEntity entity, IDbTransaction transaction = null, int? commandTimeout = null) {
            return entity == null ? null : Connection.Insert(entity, transaction, commandTimeout);
        }

        public bool Update(TEntity entity, IDbTransaction transaction = null, int? commandTimeout = null) {
            return entity != null && Connection.Update(entity, transaction, commandTimeout);
        }

        public bool Delete(TEntity entity, IDbTransaction transaction = null, int? commandTimeout = null) {
            return entity != null && Connection.Delete(entity, transaction, commandTimeout);
        }

        public TEntity GetById(long id, IDbTransaction transaction = null, int? commandTimeout = null) {
            try {
                return Connection.Get<TEntity>(id, transaction, commandTimeout);
            } catch (Exception ex) {
                throw ex;
            }
        }

        public IEnumerable<TEntity> GetAll(IDbTransaction transaction = null, int? commandTimeout = null) {
            return Connection.GetList<TEntity>(null, null, transaction, commandTimeout);
        }

        public IEnumerable<TEntity> GetAllWhere(object @where = null, object order = null, IDbTransaction transaction = null, int? commandTimeout = null) {
            return Connection.GetList<TEntity>(@where);
        }

        public void Dispose() {
            GC.SuppressFinalize(this);
        }        
    }
}
