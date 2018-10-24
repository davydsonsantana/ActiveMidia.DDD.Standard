using ActiveMidia.DataAccess.Services;
using SimpleInjector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ActiveMidia.Application.Financial.App;
using ActiveMidia.Application.Financial.Interfaces;
using ActiveMidia.Domain.Interfaces.Services.Local;
using ActiveMidia.Domain.Interfaces.Services.ExternalXPTO;
using ActiveMidia.Services.ExternalXPTO;
using ActiveMidia.Domain.Interfaces.Repository.Local;
using ActiveMidia.Domain.Interfaces.Repository.ExternalXPTO;
using ActiveMidia.Infra.Repository.Local;
using ActiveMidia.Infra.Repository.ExternalXPTO;
using ActiveMidia.Infra.Context.Interfaces;
using ActiveMidia.Infra.Context;

namespace ActiveMidia.Infra.CrossCutting.IoC
{
    public static class BootStrapper
    {
        public static void Register(Container container)
        {
            //Application Financial
            container.Register<IFinancialAppService, FinancialAppService>(Lifestyle.Singleton);            
            
            //Service Local
            container.Register<IAccountService, AccountService>(Lifestyle.Singleton);            
            container.Register<ISP_GetCashFlowService, SP_GetCashFlowService>(Lifestyle.Singleton);
            //Service ExternalXPTO
            container.Register<IExternalXPTOService, ExternalXPTOService>(Lifestyle.Singleton);            

            //Repository Local
            container.Register<IAccountRepository, AccountRepository>(Lifestyle.Singleton);            
            container.Register<ISP_GetCashFlowRepository, SP_GetCashFlowRepository>(Lifestyle.Singleton);
            //Repository ExternalXPTO
            container.Register<IExternalXPTORepository, ExternalXPTORepository>(Lifestyle.Singleton);            

            //Context
            container.Register<IDapperContext, DapperContext>(Lifestyle.Singleton);
            container.Register<IUnitOfWork, UnitOfWork>(Lifestyle.Singleton);

        }
    }
}

