using System;
using System.Collections.Generic;
using Common;

namespace Core
{
    public abstract class BaseAggregate
    {
        public Guid Id { get; protected set; }

        public long Version { get; private set; }

        protected void ApplyEvent<T>(T @event) where T : IEvent
        {
            dynamic d = this;
            d.Apply(@event);

            Version = @event.Version;
        }
    }
}