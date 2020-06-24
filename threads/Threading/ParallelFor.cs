using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Threading
{
    class ParallelFor
    {
        static CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
        static ParallelOptions parallelOptions = new ParallelOptions()
        {
            CancellationToken = cancellationTokenSource.Token,
            MaxDegreeOfParallelism = Environment.ProcessorCount + 2
        };

        public static void DoSomething()
        {
            Task.Factory.StartNew(() =>
            {
                Console.Write("Press 'x' to cancel...");
                if (Console.ReadKey().KeyChar == 'x')
                {
                    cancellationTokenSource.Cancel();
                }
            });


            var heavyTask = Task.Factory.StartNew(HeavyWorker);

            Task.WaitAll(heavyTask);

        }

        private static void HeavyWorker()
        {
            int len = 100;
            long total = 0;            
            try
            {
                Parallel.For<long>(0, len, parallelOptions, () => 0, (count, parallelLoopState, subTotal) =>
                   {
                       parallelOptions.CancellationToken.ThrowIfCancellationRequested();
                       Console.WriteLine("Loop: " + count);
                       //subTotal += count;
                       return ++subTotal;
                       ;
                   },
                    (x) =>
                    {
                        Console.WriteLine("x: " + x);
                        Interlocked.Add(ref total, x);                        
                    });
            }
            catch (OperationCanceledException e)
            {
                Console.WriteLine("Exception is here: " + e.Message);
            }
            finally
            {
                cancellationTokenSource.Dispose();
            }

            Console.WriteLine($"Total: {total}");
        }
    }

}
