using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ActiveMidia.Application.Financial.Interfaces;
using ActiveMidia.Infra.Context.Interfaces;

namespace ActiveMidia.Application.Financial.App {
    public class FinancialAppService : IFinancialAppService {
                
        private readonly IUnitOfWork _uow;
        /* private readonly IXptoService _xptoService; */

        public FinancialAppService(IUnitOfWork uow /* IXptoService xptoService  */) {            
            _uow = uow;
            /* _xptoService =  xptoService*/
        }

        public void Dispose() {
            throw new NotImplementedException();
        }

        public double GetAccountBalance(double value) {
            throw new NotImplementedException();
        }
    }
}
