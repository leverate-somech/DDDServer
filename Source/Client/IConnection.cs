using System;
using System.Threading.Tasks;
using Common;

namespace Client
{
    public interface IConnection : IDisposable
    {
        IAggregateRepository AggregateRepository { get; }

        IEventStore EventStore { get; }
        
        ICommandResult ExecuteCommand(ICommand command);
        
        Task<ICommandResult> ExecuteCommandAsync(ICommand command);
        
        IDTO ExecuteRequest(IRequest request);
        
        Task<IDTO> ExecuteRequestAsync(IRequest request);
        
        void SubscribeForEventType<T>(IEventHandler<T> eventHandler) where T : IEvent;

        void SubscribeForAggregateEvents(Guid aggregateId, int shardKey, IEventHandler eventHandler);
        
        void SubscribeForAllEvents(IEventHandler eventHandler);
    }
}