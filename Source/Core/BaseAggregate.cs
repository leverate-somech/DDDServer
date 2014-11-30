using System;
using System.Collections.Generic;
using Common;

namespace Core
{
    public abstract class BaseAggregate
    {
        /// <summary>
        /// Id of the aggregate
        /// </summary>
        public Guid Id { get; protected set; }
        
        /// <summary>
        /// Current version of the aggregate
        /// </summary>
        public long Version { get; private set; }

        /// <summary>
        /// Call to apply event on the aggregate. The method will call the internal Apply methods and update the aggregate version.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="event"></param>
        protected void ApplyEvent<T>(T @event) where T : IEvent
        {
            dynamic d = this;
            d.Apply(@event);

            Version = @event.Version;
        }
    }
}