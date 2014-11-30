using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;

namespace Example.Common
{
    public class DepositMoney  : ICommand
    {
        public DepositMoney(int shard, Guid accountId, decimal amount)
        {
            Shard = shard;
            AccountId = accountId;
            Amount = amount;
        }

        public int Shard { get; private set; }
        public Guid AccountId { get; private set; }
        public decimal Amount { get; private set; }
    }
}
