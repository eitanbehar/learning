using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Threading
{
    class TaskContinueWithExample
    {
        public static void DoSomething()
        {
            var antecedent = Task.Run(() =>
            {
                Task.Delay(2000);
                return DateTime.Now.ToShortDateString();
            });

            var continuation = antecedent.ContinueWith(p =>
            {
                return p.Result;
            });

            Console.WriteLine(continuation.Result);

            _ = Console.ReadLine();
        }
    }
}
