using System;
using System.Collections.Generic;

namespace ActiveMidia.Domain.Interfaces.Repository.Local {
    public interface ISP_GetCashFlowRepository {
        IEnumerable<KeyValuePair<DateTime, decimal>> Execute(int accountId);
    }
}
