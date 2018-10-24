using ActiveMidia.Application.Financial.Interfaces;
using ActiveMidia.Domain.Entities;
using ActiveMidia.Domain.Entities.Local;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ActiveMidia.Services.REST.Api.Controllers
{
    public class FinancialController : ApiController {

        private readonly IFinancialAppService _financialAppService;

        public FinancialController(IFinancialAppService financialAppService) {
            _financialAppService = financialAppService;
        }

        /// <summary>
        /// Get all
        /// </summary>
        /// <remarks>
        /// Obtem a lista de todos os produtos
        /// </remarks>
        /// <returns></returns>
        /// <response code ="200"></response>        
        public IEnumerable<AccountEntity> Get() {
            return null; //_financialAppService.GetAccountBalance(1);
        }

        /// <summary>
        /// Get by ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>        
        public AccountEntity Get(int id) {            
            return null; // _financialAppService
        }

        /// <summary>
        /// Search by value
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("activemidia/searchbyvalue/{value}")]
        public IEnumerable<AccountEntity> SearchByValue(double value) {
            return null; // _financialAppService
        }

        /// <summary>
        /// Adicionar produto
        /// </summary>
        /// <param name="value"></param>
        public void Post([FromBody]string value)
        {
        }

        /// <summary>
        /// Atualizar produto
        /// </summary>
        /// <param name="id"></param>
        /// <param name="value"></param>
        public void Put(int id, [FromBody]string value)
        {
        }

        /// <summary>
        /// Deletar produto
        /// </summary>
        /// <param name="id"></param>
        public void Delete(int id)
        {
        }
        
    }
}
