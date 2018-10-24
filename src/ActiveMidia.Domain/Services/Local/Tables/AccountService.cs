using ActiveMidia.Domain.Entities.Local;
using ActiveMidia.Domain.Interfaces.Repository.Local;
using ActiveMidia.Domain.Interfaces.Services.Local;
using ActiveMidia.Domain.Services.Local.Common;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Threading.Tasks;

namespace ActiveMidia.DataAccess.Services {
    public class AccountService : Service<AccountEntity>, IAccountService {

        IAccountRepository accountRepository;

        public AccountService(IAccountRepository _accountRepository)
            : base(_accountRepository) {
            accountRepository = _accountRepository;
        }                

        public IEnumerable<AccountEntity> GetByDateBetween(ref DateTime iniDate, DateTime endDate) {
            return accountRepository.GetByDateBetween(iniDate, endDate);
        }

    }
}
