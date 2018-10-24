using ActiveMidia.Application.Financial.App;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Topshelf;

namespace ActiveMidia.Apresentacao.BatchSample {
    class Program {
        static void Main(string[] args) {

            SimpleInjectorWindowsServiceInitializer.Initialize();

            var robot = SimpleInjectorWindowsServiceInitializer.container.GetInstance<FinancialAppService>();

            var xpto = ConfigurationManager.AppSettings["xpto"];
            
            HostFactory.Run(x => {
                x.Service<FinancialAppService>(s => {
                    s.ConstructUsing(name => robot);
                    //s.WhenStarted(rs => rs.Start());
                    //s.WhenStopped(rs => rs.Stop());
                });
                x.DependsOnEventLog();
                x.RunAsLocalSystem();

                x.SetDescription("Batch service.");
                x.SetDisplayName("ActiveMidia.Batch - " + xpto);
                x.SetServiceName("ActiveMidia.Batch - " + xpto);
            });
        }        
    }
}
