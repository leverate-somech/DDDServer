using System;

namespace Common
{
    public interface IEvent
    {
        Guid AggregateId { get; }
        int ShardKey { get; }
        long Version { get; }
    }
}