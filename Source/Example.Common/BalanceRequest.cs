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
        public BalanceRequest(int shard, Guid accountId)
        {
            Shard = shard;
            AccountId = accountId;
        }

        public int Shard { get; private set; }
        public Guid AccountId { get; private set; }
    }
}
