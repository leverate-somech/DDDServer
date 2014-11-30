using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Common;

namespace Client
{
    public interface IConnection : IDisposable
    {
        /// <summary>
        /// Return a shard we can use to create new aggregates
        /// </summary>
        /// <returns></returns>
        int GetRandomShard();

        /// <summary>
        /// Execute a command and return the command result
        /// </summary>
        /// <param name="command">Command to execute</param>
        /// <returns>Command result</returns>
        ICommandResult ExecuteCommand(ICommand command);
        
        /// <summary>
        /// Execute a command asynchronously and return a Task.
        /// </summary>
        /// <param name="command">Command to execute</param>
        /// <returns>Task</returns>
        Task<ICommandResult> ExecuteCommandAsync(ICommand command);
        
        /// <summary>
        /// Send a request to a shard and returns a DTO
        /// </summary>
        /// <param name="request">Request</param>
        /// <returns>DTO that was requested</returns>
        T ExecuteRequest<T>(IRequest request) where T: IDTO;

        /// <summary>
        /// Send a request to a shard asynchronously
        /// </summary>
        /// <param name="request">Request</param>
        /// <returns>Task</returns>
        Task<T> ExecuteRequestAsync<T>(IRequest request)where T: IDTO;

        /// <summary>
        /// Get all events for specific aggregate
        /// </summary>
        /// <param name="shard">Shard where aggregate is stored</param>
        /// <param name="aggregateId">Id of the aggregate</param>
        /// <returns>All the events of the aggregate</returns>
        IEnumerable<IEvent> GetEvents(int shard, Guid aggregateId);

        /// <summary>
        /// Get all events for specific aggregate asynchronously
        /// </summary>
        /// <param name="shard">Shard where aggregate is stored</param>
        /// <param name="aggregateId">Id of the aggregate</param>
        /// <returns>Task</returns>
        Task<IEnumerable<IEvent>> GetEventsAsync(int shard, Guid aggregateId);

        /// <summary>
        /// Get events for specific aggregate between versions
        /// </summary>
        /// <param name="shard">Shard where aggregate is stored</param>
        /// <param name="aggregateId">Id of the aggregate</param>
        /// <returns>Events of the aggregate</returns>
        IEnumerable<IEvent> GetEventsBetweenVersions(int shard, Guid aggregateId, int fromVersionIncluding, int toVersionExcluding);

        /// <summary>
        /// Get events for specific aggregate between versions asynchronously
        /// </summary>
        /// <param name="shard">Shard where aggregate is stored</param>
        /// <param name="aggregateId">Id of the aggregate</param>
        /// <returns>Task</returns>
        Task<IEnumerable<IEvent>> GetEventsBetweenVersionsAsync(int shard, Guid aggregateId, int fromVersionIncluding, int toVersionExcluding);        

        /// <summary>
        /// Subscribe for specific event
        /// </summary>
        /// <typeparam name="T">Type of the event</typeparam>
        /// <param name="eventHandler">Event handler</param>
        void SubscribeForEventType<T>(IEventHandler<T> eventHandler) where T : IEvent;        
        
        /// <summary>
        /// Subscribe for all events
        /// </summary>
        /// <param name="eventHandler"></param>
        void SubscribeForAllEvents(IEventHandler eventHandler);
    }
}