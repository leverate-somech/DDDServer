using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core;
using Example.Common;

namespace Example.Server.Domain
{
    class Account : BaseAggregate
    {
        public decimal Balance { get; private set; }

        protected void Apply(AccountCreated accountCreated)
        {
            Balance = 0;
            Id = accountCreated.AggregateId;
            Shard = accountCreated.Shard;
        }

        protected void Apply(MoneyDeposited moneyDeposited)
        {
            Balance += moneyDeposited.Amount;
        }

        public static Account CreateAccount()
        {
            Account account = new Account();
            account.ApplyEvent(new AccountCreated(Guid.NewGuid(), CurrentShard.Shard, 1));

            return account;
        }

        public void DepositMoney(decimal amount)
        {
            ApplyEvent(new MoneyDeposited(Id, Shard, Version+1, amount));
        }
    }
}
