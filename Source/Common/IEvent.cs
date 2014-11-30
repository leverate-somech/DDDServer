using System;

namespace Common
{
    public interface IEvent
    {
        Guid AggregateId { get; }        
        long Version { get; }
    }
}