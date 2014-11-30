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
        /// The shard to execute the command on
        /// </summary>
        int Shard { get; }
    }
}
