using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Threading
{
    class TasksExample
    {
        public static void DoSomething()
        {
            var task = new Task<string>(DoWorker);
            task.Start();
            task.Wait();

            Console.WriteLine($"Result: {task.Result}"); 
            _ = Console.ReadLine();


        }

        private static string DoWorker()
        {
            Thread.Sleep(1000);
            return "completed";
        }
    }
}
