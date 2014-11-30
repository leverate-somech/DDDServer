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
        public DepositMoney(Guid aggregateId, int version, decimal amount)
        {
            AggregateId = aggregateId;
            Version = version;
            Amount = amount;
        }

        public Guid AggregateId { get; private set; }

        public int Version { get; private set; }

        public decimal Amount { get; private set; }       
    }
}
