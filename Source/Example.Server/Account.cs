using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;
using Core;
using Example.Common;

namespace Example.Server
{
    class Account : BaseAggregate
    {
        public decimal Balance { get; private set; }

        protected void Apply(AccountCreated accountCreated)
        {
            Balance = 0;
            Id = accountCreated.AggregateId;            
        }

        protected void Apply(MoneyDeposited moneyDeposited)
        {
            Balance += moneyDeposited.Amount;
        }

        public ICommandResult Handle(CreateAccount command)
        {
            ApplyEvent(new AccountCreated(command.AggregateId, 1));

            return new SuccessCommandResult();
        }

        public ICommandResult Handle(DepositMoney command)
        {
            ApplyEvent(new MoneyDeposited(Id, Version+1, command.Amount));

            return new SuccessCommandResult();
        }

        public BalanceDTO Handle(BalanceRequest balanceRequest)
        {
            return new BalanceDTO(Balance);
        }        
    }
}
