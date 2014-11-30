using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class SelfHost
    {
        /// <summary>
        /// Register Command handlers, Request handlers and Aggregates from the DLL
        /// </summary>
        /// <param name="type"></param>
        public void RegisterAssembly(Type type)
        {

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
