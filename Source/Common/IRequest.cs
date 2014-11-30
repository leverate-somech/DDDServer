using System;

namespace Common
{
    /// <summary>
    /// Request for information, request are reads froma aggregates, request don't cause change of data.
    /// </summary>
    public interface IRequest
    {        
        Guid AggregateId { get; }
    }
}