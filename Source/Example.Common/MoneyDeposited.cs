using System;
using Common;

namespace Example.Common
{
    public class MoneyDeposited : IEvent
    {
        public MoneyDeposited(Guid aggregateId, int shard, long version, decimal amount)
        {
            AggregateId = aggregateId;
            Shard = shard;
            Version = version;
            Amount = amount;
        }

        public Guid AggregateId { get; private set; }
        public int Shard { get; private set; }
        public long Version { get; private set; }
        public decimal Amount { get; private set; }
    }
}