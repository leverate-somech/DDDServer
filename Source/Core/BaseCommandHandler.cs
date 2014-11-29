using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;

namespace Core
{
    public abstract class BaseCommandHandler<T> where T: ICommand
    {
        public BaseCommandHandler()
        {
            
        }

        protected IAggregateRepository AggregateRepository { get; private set; }

        protected IUnitOfWork CreateUnitOfWork()
        {
            throw new NotImplementedException();
        }

        protected ICommandResult Success()
        {
            return new SuccessCommandResult();
        }

        protected ICommandResult Error(string reason = "")
        {
            return new ErrorCommandResult(reason);
        }

        protected abstract ICommandResult Handle(ICommand command);
    }
}
