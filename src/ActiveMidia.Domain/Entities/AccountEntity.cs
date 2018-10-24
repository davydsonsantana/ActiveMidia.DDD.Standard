using ActiveMidia.Domain.Entities.Validation.Account;
using ActiveMidia.Domain.Validation;
using System;

namespace ActiveMidia.Domain.Entities.Local
{
    /// <summary>
    /// Account Entity
    /// </summary>
    public class AccountEntity {
        
        /// <summary>
        /// ID
        /// </summary>
        public int Id { get; set; }
        
        /// <summary>
        /// Description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Date
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// Consistency validation result
        /// </summary>
        public ValidationResult ValidationResult { get; private set; }

        /// <summary>
        /// Validation return
        /// </summary>
        public bool IsValid
        {
            get
            {
                ValidationResult = new AccountConsistencyValidation().Valid(this);
                return ValidationResult.IsValid;
            }
        }
    }
}

