using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Threading
{
    class MultipleAutoResetEvent
    {

        static AutoResetEvent waitHandle = new AutoResetEvent(false);

        public static void DoSomething()
        {
            Task.Factory.StartNew(Worker);
            Task.Factory.StartNew(Worker);
            Task.Factory.StartNew(Worker);
            Task.Factory.StartNew(Worker);
            Task.Factory.StartNew(Worker);

            Thread.Sleep(1000);

            Console.WriteLine("Press a key to continue...");
            _ = Console.ReadKey();

            waitHandle.Set();
            waitHandle.Set();
            waitHandle.Set();


        }

        private static void Worker()
        {
            Console.WriteLine("Starting worker: " + Task.CurrentId);
            waitHandle.WaitOne();
            Console.WriteLine("Continuing worker: " + Task.CurrentId);

        }
    }
}
