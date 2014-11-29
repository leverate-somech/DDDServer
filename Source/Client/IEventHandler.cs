using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;

namespace Client
{
    public interface IEventHandler<T> where T : IEvent
    {
        void Handle(T @event);
    }

    public interface IEventHandler
    {
        void Handle(IEvent @event);
    }
}
