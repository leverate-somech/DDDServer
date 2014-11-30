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
                await m_connection.ExecuteCommandAsync(new DepositMoney(depositMoneyModel.Shard, depositMoneyModel.AccountId, depositMoneyModel.Amount));

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
            int shard = m_connection.GetRandomShard();

            ICommandResult result = await m_connection.ExecuteCommandAsync(new CreateAccount(shard));

            if (result is CreateAccountResult)
            {
                var accountResult = result as CreateAccountResult;

                return Ok(new {Shard = shard, AccoundId = accountResult.AccountId});
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpGet]
        public async Task<IHttpActionResult> GetBalance(AccountKey accountKey)
        {
            var balance =
                await
                    m_connection.ExecuteRequestAsync<BalanceDTO>(new BalanceRequest(accountKey.Shard,
                        accountKey.AccountId));

            return Ok(balance.Balance);            
        }
    }
}
