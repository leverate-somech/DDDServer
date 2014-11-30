using System;

namespace Common
{
    public interface IEvent
    {
        Guid AggregateId { get; }
        int Shard { get; }
        long Version { get; }
    }
}