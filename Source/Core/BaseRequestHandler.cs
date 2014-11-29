using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;

namespace Core
{
    public abstract class BaseRequestHandler<T> where T : IRequest
    {
        protected IAggregateRepository AggregateRepository { get; private set; }

        protected abstract IDTO Handle(T request);
    }
}
