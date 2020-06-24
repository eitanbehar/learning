using System;
using System.Threading;

namespace Threading
{
    class Program
    {
        static void Main()
        {
            //ExampleManualResetEvent.DoSomeWork();
            //TasksExample.DoSomething();
            //TaskFactoryExample.DoSomething();
            //TaskContinueWithExample.DoSomething();
            //LockExample.DoSomething();
            //DeadLockExample.DoSomething();
            //AutoReset.DoSomething();
            //MultipleAutoResetEvent.DoSomething();
            //SimpleParallel.DoSomething();
            ParallelFor.DoSomething();

            Console.WriteLine("Press any key to continue...");
            _ = Console.ReadKey();


        }
    }
}
