using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Threading
{
    class SimpleParallel
    {
        public static void DoSomething()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
                Thread.Sleep(500);
            }
            Console.WriteLine($"Time taken: {stopwatch.ElapsedMilliseconds}");
            stopwatch.Restart();
            
            Parallel.For(0, 10, i =>
            {
                Console.WriteLine(i);
                Thread.Sleep(500);
            });
            Console.WriteLine($"Time taken: {stopwatch.ElapsedMilliseconds}");
        }

    }
}
