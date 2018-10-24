using ActiveMidia.Domain.Interfaces.Services.ExternalXPTO;
using ActiveMidia.Domain.Interfaces.Repository.ExternalXPTO;

namespace ActiveMidia.Services.ExternalXPTO {
    public class ExternalXPTOService : IExternalXPTOService {
                
        IExternalXPTORepository externalService;        

        public ExternalXPTOService(IExternalXPTORepository _externalService) {
            externalService = _externalService;            
        }

        public void DoSomethingExternal(string info) {
            throw new System.NotImplementedException();
        }
    }
}
