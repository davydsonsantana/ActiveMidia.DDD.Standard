using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Threading.Tasks;

namespace ActiveMidia.Domain.Interfaces.Services.Local {
    public interface ISP_GetCashFlowService {

        IEnumerable<KeyValuePair<DateTime, decimal>> Execute(int accountId);

    }
}
