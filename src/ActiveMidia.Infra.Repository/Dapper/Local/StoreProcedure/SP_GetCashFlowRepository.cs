using System;
using System.Linq;
using Dapper;
using System.Threading.Tasks;
using System.Collections.Generic;

using ActiveMidia.Domain.Interfaces.Repository.Local;
using ActiveMidia.Infra.Context.Interfaces;

namespace ActiveMidia.Infra.Repository.Local {
    public class SP_GetCashFlowRepository : ISP_GetCashFlowRepository {

        IDapperContext dapperContext;

        public SP_GetCashFlowRepository(IDapperContext _dapperContext) {
            dapperContext = _dapperContext;
        }

        /// <summary>
        /// Obtem todos os profiles associados a conta para gerar interação
        /// </summary>
        /// <param name="idInstagramUser"></param>
        /// <returns></returns>
        public IEnumerable<KeyValuePair<DateTime, decimal>> Execute(int accountId) {
            
            var p = new DynamicParameters();
            p.Add("@Param1", accountId);

            string query = "sp_get_cash_flow";

            var result = dapperContext.Connection.Query(query, p, null, true, null, System.Data.CommandType.StoredProcedure);
            
            var resultMapped = result.Select(r => new KeyValuePair<DateTime, decimal>(r.date, r.id_account));

            return resultMapped;
        }
    }
}
