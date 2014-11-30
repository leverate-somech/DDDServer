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
    public class DepositMoneyCommandHandler : BaseCommandHandler<DepositMoney>
    {
        protected override ICommandResult Handle(DepositMoney command)
        {
            Account account;

            if (AggregateRepository.TryGetAggregate(command.AccountId, out account))
            {
                account.DepositMoney(command.Amount);
                return Success();
            }
            else
            {
                return Error("Account doesn't exist");
            }
        }
    }
}
