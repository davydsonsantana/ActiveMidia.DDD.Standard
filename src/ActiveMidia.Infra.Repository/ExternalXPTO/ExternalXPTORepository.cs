using Dapper;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using ActiveMidia.Domain.Interfaces.Repository.ExternalXPTO;

namespace ActiveMidia.Infra.Repository.ExternalXPTO {
    public class ExternalXPTORepository : IExternalXPTORepository {
        
        public ExternalXPTORepository() {
            
        }

        public void DoSomethingExternal(string info) {
            //Do external calls
            throw new NotImplementedException();
        }
    }

}
