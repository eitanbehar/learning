using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Threading
{
    class TaskCompletionSource
    {
        public static void DoSomething()
        {
            TaskCompletionSource<Product> taskCompletionSource 
                = new TaskCompletionSource<Product>();
            Task<Product> lazyTask = taskCompletionSource.Task;

            Task.Factory.StartNew(() =>
            {
                Thread.Sleep(1000);
                Console.WriteLine("Return a product...");
                taskCompletionSource.SetResult(new Product() { Id = 350 });
            });

            Task.Factory.StartNew(() =>
            {
                Console.WriteLine("Press 'x' to get a product, or enter to exit...");
                if (Console.ReadKey().KeyChar == 'x')
                    Console.WriteLine($"Product ID: {lazyTask.Result.Id}");
            });

            Thread.Sleep(3000);
            _ = Console.ReadLine();

        }
    }

    internal class Product
    {
        public int Id { get; set; }
    }
}
