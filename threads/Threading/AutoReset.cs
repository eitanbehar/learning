using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Threading
{
    class AutoReset
    {
        static AutoResetEvent resetEvent = new AutoResetEvent(false);

        public static void DoSomething()
        {

            Console.WriteLine("starting main thread");
            Thread.Sleep(2000);
            new Thread(SomeWorker).Start();

            Console.WriteLine("Thread not signaled (set) yet");
            _ = Console.ReadKey();

            resetEvent.Set();

            Console.WriteLine("Completed");            
        }

        private static void SomeWorker()
        {
            Console.WriteLine("Entering Worker");
            Thread.Sleep(2000);
            Console.WriteLine("Worker did something, but has ot finished");
            resetEvent.WaitOne();
            Console.WriteLine("Worker is continuing");
            Thread.Sleep(2000);
            Console.WriteLine("Worker has finished");
        }
    }
}
