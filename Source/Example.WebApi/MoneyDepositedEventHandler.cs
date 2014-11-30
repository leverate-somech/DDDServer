using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Client;
using Example.Common;

namespace Example.WebApi
{
    public class MoneyDepositedEventHandler : IEventHandler<MoneyDeposited>
    {
        public void Handle(MoneyDeposited @event)
        {
            // TODO: call to Connection.SubscribeForEventType when application starts
            // TODO: publish to signalr
        }
    }
}
