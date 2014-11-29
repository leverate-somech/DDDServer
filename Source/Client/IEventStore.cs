using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;

namespace Client
{
    public interface IEventStore
    {
        IEnumerable<IEvent> GetEventsFor(int shardKey, Guid aggregateId);

        IEnumerable<IEvent> GetEventsSince(int shardKey, Guid aggregateId, int fromVersionIncluding);        
    }
}
