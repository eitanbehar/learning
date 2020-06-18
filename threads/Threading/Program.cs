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

            DeadLockExample.DoSomething();
        }
    }
}
