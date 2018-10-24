using ActiveMidia.Domain.Entities.Local;
using ActiveMidia.Domain.Entities.Spec.Account;
using ActiveMidia.Domain.Validation;

namespace ActiveMidia.Domain.Entities.Validation.Account
{
    public class AccountConsistencyValidation : Validation<AccountEntity>
    {
        public AccountConsistencyValidation()
        {
            AddRule(new ValidationRule<AccountEntity>(new AccountMustHaveDescriptionSpec(), "Account must have a description."));
        }
    }
}
