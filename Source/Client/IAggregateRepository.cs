using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    public interface IAggregateRepository
    {
        T GetAggregate<T>(int shardKey, Guid aggregateId);

        Task<T> GetAggregateAsync<T>(int shardKey, Guid aggregateId);
    }
}
