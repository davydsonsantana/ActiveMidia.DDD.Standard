using ActiveMidia.Domain.Entities.Local;
using ActiveMidia.Domain.Interfaces.Repository.ActiveMidia.Comum;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ActiveMidia.Domain.Interfaces.Repository.Local
{
    public interface IAccountRepository : IRepository<AccountEntity>
    {
        IEnumerable<AccountEntity> GetByDateBetween(DateTime iniDate, DateTime endDate);
    }
}
