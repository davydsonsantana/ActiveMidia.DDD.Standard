using ActiveMidia.Domain.Validation;

namespace ActiveMidia.Domain.Interfaces.Validation
{
    public interface IValidation<in TEntity>
    {
        ValidationResult Valid(TEntity entity);
    }
}
