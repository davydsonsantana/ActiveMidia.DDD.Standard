using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using ActiveMidia.Domain.Interfaces.Services.Local;
using ActiveMidia.Domain.Interfaces.Repository.Local;

namespace ActiveMidia.DataAccess.Services {
    public class SP_GetCashFlowService : ISP_GetCashFlowService {

        ISP_GetCashFlowRepository sp_GetCashFlowRepository;

        public SP_GetCashFlowService(ISP_GetCashFlowRepository _sp_GetCashFlowRepository) {
            sp_GetCashFlowRepository = _sp_GetCashFlowRepository;
        }        

        IEnumerable<KeyValuePair<DateTime, decimal>> ISP_GetCashFlowService.Execute(int idInstagramUser) {
            return sp_GetCashFlowRepository.Execute(idInstagramUser);
        }
    }
}
