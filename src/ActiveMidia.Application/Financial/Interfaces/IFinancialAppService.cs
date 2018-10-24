using ActiveMidia.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActiveMidia.Application.Financial.Interfaces
{
    public interface IFinancialAppService : IAppService
    {
        double GetAccountBalance(double value);
    }
}
