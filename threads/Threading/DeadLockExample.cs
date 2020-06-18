using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Threading
{
    class DeadLockExample
    {
        public static void DoSomething()
        {

            var logicLock = new object();
            var processLock = new object();

            var task1 = new Task(() =>
            {
                lock (logicLock)
                {
                    Task.Delay(1000);
                    lock(processLock)
                        Console.WriteLine("Logic lock");
                }
            });

            var task2 = new Task(() =>
            {
                lock (processLock)
                {
                    Task.Delay(1000);
                    lock(logicLock)
                        Console.WriteLine("Logic lock");
                }
            });

            task1.Start(); task2.Start();

            Task.WaitAll(task1, task2);

            Console.WriteLine("End of process here");
            _ = Console.ReadKey();


        }
    }
}
