using ActiveMidia.Domain.Interfaces.Spec;


namespace ActiveMidia.Domain.Entities.Spec
{
    public class GenericSpecification<T> : ISpecification<T>
    {
        public bool IsSatisfiedBy(T obj)
        {
            return true;
        }
    }
}
