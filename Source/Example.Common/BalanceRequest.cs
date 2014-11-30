using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;

namespace Example.Common
{
    public class BalanceRequest : IRequest
    {
        public BalanceRequest(Guid aggregateId)
        {
            AggregateId = aggregateId;
        }

        public Guid AggregateId { get; private set; }
    }
}
