using ActiveMidia.Domain.Entities.Spec;
using ActiveMidia.Domain.Entities.Spec.Account;
using ActiveMidia.Domain.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActiveMidia.Domain.Entities.Validation {
    public class GenericValidation<TEntity> : Validation<TEntity> where TEntity : class {
        public GenericValidation() {
            AddRule(new ValidationRule<TEntity>(new GenericSpecification<TEntity>(), "Validation."));
        }
    }
}
