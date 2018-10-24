using ActiveMidia.Domain.Validation;

namespace ActiveMidia.Domain.Interfaces.Validation {
    public interface ISelfValidation {
        ValidationResult ValidationResult { get; }
        bool IsValid { get; }
    }
}
