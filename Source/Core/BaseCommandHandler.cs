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

        /// <summary>
        /// Repository to retrieve aggregate from store. Only provides aggregates that are on the same shard as Command
        /// </summary>
        protected IAggregateRepository AggregateRepository { get; private set; }        

        /// <summary>
        /// Use when want to return a general success result
        /// </summary>
        /// <returns></returns>
        protected ICommandResult Success()
        {
            return new SuccessCommandResult();
        }

        /// <summary>
        /// Use when want to return general error result
        /// </summary>
        /// <param name="reason">Reason of the error</param>
        /// <returns></returns>
        protected ICommandResult Error(string reason = "")
        {
            return new ErrorCommandResult(reason);
        }

        /// <summary>
        /// Override to handle the command
        /// </summary>
        /// <param name="command"></param>
        /// <returns></returns>
        protected abstract ICommandResult Handle(ICommand command);
    }
}
