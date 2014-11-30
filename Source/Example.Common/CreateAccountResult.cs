using System;
using Common;

namespace Example.Common
{
    public class CreateAccountResult : SuccessCommandResult
    {
        public CreateAccountResult(Guid accountId)
        {
            AccountId = accountId;
        }

        public Guid AccountId { get; private set; }
    }
}