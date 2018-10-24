using ActiveMidia.Domain.Entities.Local;
using ActiveMidia.Domain.Interfaces.Services.Local.Common;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Threading.Tasks;

namespace ActiveMidia.Domain.Interfaces.Services.Local
{
    public interface IAccountService : IService<AccountEntity>
    {
        IEnumerable<AccountEntity> GetByDateBetween(ref DateTime iniDate, DateTime endDate);
    }
}
