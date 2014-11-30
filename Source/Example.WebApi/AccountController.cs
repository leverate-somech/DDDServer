using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using Client;
using Common;
using Example.Common;

namespace Example.WebApi
{
    public class AccountController : ApiController
    {
        private readonly IConnection m_connection;

        public AccountController(IConnection connection)
        {
            m_connection = connection;
        }

        [HttpPost]
        public async Task<IHttpActionResult> DepositMoney(DepositMoneyModel depositMoneyModel)
        {            
            ICommandResult result = 
                await m_connection.ExecuteCommandAsync(
                new DepositMoney(depositMoneyModel.AccountId, depositMoneyModel.Version, depositMoneyModel.Amount));

            if (result.Success)
            {                
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpPost]
        public async Task<IHttpActionResult> CreateAccount()
        {
            Guid accountId = Guid.NewGuid();

            ICommandResult result = await m_connection.ExecuteCommandAsync(new CreateAccount(accountId));

            if (result.Success)
            {                
                return Ok(new {AccountId =accountId });
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpGet]
        public async Task<IHttpActionResult> GetBalance(Guid accountId)
        {
            var balance = await m_connection.ExecuteRequestAsync<BalanceDTO>(new BalanceRequest(accountId));

            return Ok(balance.Balance);            
        }
    }
}
