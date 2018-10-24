using System;
using System.Collections.Generic;
using System.Data;
using ActiveMidia.Domain.Interfaces.Repository.ActiveMidia.Comum;
using ActiveMidia.Domain.Validation;
using ActiveMidia.Domain.Interfaces.Validation;
using ActiveMidia.Domain.Interfaces.Services.Local.Common;

namespace ActiveMidia.Domain.Services.Local.Common {
    public class Service<TEntity> : IService<TEntity> where TEntity : class {
        private readonly IRepository<TEntity> _Repository;
        private readonly ValidationResult _validationResult;

        public Service(IRepository<TEntity> Repository) {
            _Repository = Repository;
        }

        public IDbConnection GetConnection() {
            return _Repository.GetConnection();
        }

        protected ValidationResult ValidationResult {
            get { return _validationResult; }
        }

        public ValidationResult SaveNew(TEntity entity, IDbTransaction transaction = null, int? commandTimeout = default(int?)) {
            /*
            if (!_validationResult.IsValid)
                return ValidationResult;*/

            var selfValidationEntity = entity as ISelfValidation;
            if (selfValidationEntity != null && !selfValidationEntity.IsValid)
                return selfValidationEntity.ValidationResult;

            var adicionou = _Repository.SaveNew(entity);
            if (adicionou == null)
                _validationResult.Add("This entity is null, please try again! Entity:" + entity.ToString() + " Add");
            return _validationResult;
        }

        public ValidationResult Update(TEntity entity, IDbTransaction transaction = null, int? commandTimeout = default(int?)) {
            /*
            if (!ValidationResult.IsValid)
                return ValidationResult;*/

            var selfValidationEntity = entity as ISelfValidation;
            if (selfValidationEntity != null && !selfValidationEntity.IsValid)
                return selfValidationEntity.ValidationResult;

            var updated = _Repository.Update(entity);
            if (!updated)
                _validationResult.Add("This entity is null, please try again! Entity: " + entity + " Update");
            return _validationResult;
        }

        public ValidationResult Delete(TEntity entity, IDbTransaction transaction = null, int? commandTimeout = default(int?)) {
            /*
            if (!ValidationResult.IsValid)
                return ValidationResult;*/

            var deleted = _Repository.Delete(entity);
            if (!deleted)
                _validationResult.Add("This entity is null, please try again! Entity: " + entity.ToString() + " Delete");
            return _validationResult;
        }

        public TEntity GetById(long id, IDbTransaction transaction = null, int? commandTimeout = null) {
            return _Repository.GetById(id);
        }

        public IEnumerable<TEntity> GetAll(IDbTransaction transaction = null, int? commandTimeout = null) {
            return _Repository.GetAll();
        }

        public IEnumerable<TEntity> GetAllWhere(object @where = null, object order = null, IDbTransaction transaction = null, int? commandTimeout = null) {
            return _Repository.GetAllWhere(@where);
        }       
    }
}
