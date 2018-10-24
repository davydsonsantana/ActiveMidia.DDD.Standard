using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActiveMidia.Domain.Interfaces.Spec
{
    public interface ISpecification<in TEntity>
    {
         bool IsSatisfiedBy(TEntity entity);
    }
}
