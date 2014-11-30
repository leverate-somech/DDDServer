using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class SelfHost
    {
        /// <summary>
        /// Register Command handlers, Request handlers and Aggregates from assembly
        /// </summary>
        /// <param name="type">Type of object that is inside the assembly to register</param>
        public void RegisterAssembly(Type type)
        {

        }

        /// <summary>
        /// Register Command handlers, Request handlers and Aggregates from assembly
        /// </summary>
        /// <param name="assembly"></param>
        public void RegisterAssembly(Assembly assembly)
        {
            
        }

        /// <summary>
        /// Register Command handlers, Request handlers and Aggregates from assembly
        /// </summary>
        public void RegisterExecutingAssembly()
        {
            RegisterAssembly(Assembly.GetCallingAssembly());
        }


        public void ConfigureSnapshot(TimeSpan interval, int numberOfSnapshotToKeep)
        {
            
        }

        public void Start()
        {
            throw new NotImplementedException();
        }

        public void Stop()
        {
            throw new NotImplementedException();
        }        
    }
}
