using ActiveMidia.Domain.Entities.Validation;
using ActiveMidia.Domain.Interfaces.Validation;
using ActiveMidia.Domain.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActiveMidia.Domain.Entities {
    public class CashMovementEntity : ISelfValidation {

        public int Id { get; set; }
        public double Value { get; set; }        
        public DateTime DataCadastro { get; set; }        

        /// <summary>
        /// Consistency validation
        /// </summary>
        public ValidationResult ValidationResult { get; private set; }

        /// <summary>
        ///  Validation return
        /// </summary>
        public bool IsValid {
            get {
                ValidationResult = new GenericValidation<CashMovementEntity>().Valid(this);
                return ValidationResult.IsValid;
            }
        }
    }
}
