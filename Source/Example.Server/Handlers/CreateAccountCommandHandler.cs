using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;
using Core;
using Example.Common;
using Example.Server.Domain;

namespace Example.Server.Handlers
{
    public class CreateAccountCommandHandler : BaseCommandHandler<CreateAccount>
    {
        protected override ICommandResult Handle(CreateAccount command)
        {            
            Account account = Account.CreateAccount();

            AggregateRepository.SaveAggregate(account);

            return new CreateAccountResult(account.Id);
        }
    }
}
