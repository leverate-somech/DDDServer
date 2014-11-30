using System;
using Common;

namespace Example.Common
{
    public class MoneyDeposited : IEvent
    {
        public MoneyDeposited(Guid aggregateId, long version, decimal amount)
        {
            AggregateId = aggregateId;            
            Version = version;
            Amount = amount;
        }

        public Guid AggregateId { get; private set; }        
        public long Version { get; private set; }
        public decimal Amount { get; private set; }
    }
}