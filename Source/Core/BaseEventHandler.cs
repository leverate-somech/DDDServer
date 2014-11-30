using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public interface IEventHandler<T> where T : IEvent
    {
        void Handle(T @event);
    }

    /// <summary>
    /// Base Event handler for events, becuase one EventHandler can handle multiple events to specify the event type to handle inhert from IEventHandler
    /// </summary>
    public abstract class BaseEventHandler
    {
        /// <summary>
        /// Repository to retrieve aggregate from store. Only provides aggregates that are on the same shard as Command
        /// </summary>
        protected IAggregateRepository AggregateRepository { get; private set; }        
    }
}
