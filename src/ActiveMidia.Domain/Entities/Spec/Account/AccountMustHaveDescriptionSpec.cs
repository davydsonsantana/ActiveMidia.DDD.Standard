using ActiveMidia.Domain.Entities.Local;
using ActiveMidia.Domain.Interfaces.Spec;
using System;

namespace ActiveMidia.Domain.Entities.Spec.Account
{
    public class AccountMustHaveDescriptionSpec : ISpecification<AccountEntity>
    {
        public bool IsSatisfiedBy(AccountEntity account)
        {
            return !String.IsNullOrEmpty(account.Description) && !String.IsNullOrWhiteSpace(account.Description);
        }
    }
}
