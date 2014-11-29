using System;

namespace Core
{
    public interface IAggregateRepository
    {
        void GetAggregate(Guid shardKey);        
    }
}