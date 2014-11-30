using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Core;

namespace Example.Server
{
    class Program
    {
        static void Main(string[] args)
        {
            SelfHost selfHost = new SelfHost();
            selfHost.RegisterExecutingAssembly();

            selfHost.Start();

            Console.WriteLine("Press enter to exit");
            Console.ReadLine();
        }
    }
}
