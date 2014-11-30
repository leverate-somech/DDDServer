using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    /// <summary>
    /// Command to execute on aggregate.
    /// </summary>
    public interface ICommand
    {
        /// <summary>
        /// Id of the aggregate to run the command on
        /// </summary>
        Guid AggregateId { get; }

        /// <summary>
        /// Expected version of the aggregate
        /// </summary>
        int Version { get; }
    }
}
