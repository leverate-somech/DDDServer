using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;
using Core;
using Example.Common;
using Example.Server.Domain;

namespace Example.Server.Handlers
{
    public class BalanceRequestHandler : BaseRequestHandler<BalanceRequest>
    {
        protected override IDTO Handle(BalanceRequest request)
        {
            var account = AggregateRepository.GetAggregate<Account>(request.AccountId);

            return new BalanceDTO(account.Balance);
        }
    }
}
