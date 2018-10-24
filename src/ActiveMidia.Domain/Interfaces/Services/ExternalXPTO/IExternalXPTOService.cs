using ActiveMidia.Domain.Enum;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Threading.Tasks;

namespace ActiveMidia.Domain.Interfaces.Services.ExternalXPTO {
    public interface IExternalXPTOService {
        void DoSomethingExternal(string info);        
    }
}
