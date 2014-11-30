using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;

namespace Example.Common
{
    public class AccountCreated : IEvent
    {
        public AccountCreated(Guid aggregateId, int shard, long version)
        {
            AggregateId = aggregateId;
            Shard = shard;
            Version = version;
        }

        public Guid AggregateId { get; private set; }
        public int Shard { get; private set; }
        public long Version { get; private set; }
    }
}
