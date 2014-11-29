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
    /// Base Event handler for events, becuase one EventHandler can handle one then one event to handle event class should also inhert from IEventHandler<T>
    /// </summary>
    public abstract class BaseEventHandler
    {
        protected IAggregateRepository AggregateRepository { get; private set; }

        protected IUnitOfWork CreateUnitOfWork()
        {
            throw new NotImplementedException();
        }
    }
}
