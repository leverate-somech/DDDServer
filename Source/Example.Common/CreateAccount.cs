using System;
using Common;

namespace Example.Common
{
    public class CreateAccount: ICommand
    {
        public CreateAccount(Guid aggregateId)
        {
            AggregateId = aggregateId;
            Version = 0; // We don't expect the aggregate to exist
        }

        public Guid AggregateId { get; private set; }

        public int Version { get; private set; }
    }
}