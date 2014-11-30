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
        public void RegisterAggregate<T>()
        {
            
        }

        public void RegisterAggregate(Type aggregateType)
        {

        }

        /// <summary>
        /// Register Aggregates from assembly
        /// </summary>
        /// <param name="type">Type of object that is inside the assembly to register</param>
        public void RegisterAssembly(Type type)
        {

        }

        /// <summary>
        /// Register Aggregates from assembly
        /// </summary>
        /// <param name="assembly"></param>
        public void RegisterAssembly(Assembly assembly)
        {
            
        }

        /// <summary>
        /// Register Aggregates from executing assembly
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
