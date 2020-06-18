using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Threading
{
    class ExampleManualResetEvent
    {
        private static ManualResetEvent manualResetEvent = new ManualResetEvent(false);

        public static void DoSomeWork()
        {
            Task task = Task.Factory.StartNew(() =>
            {
                GetDataFromServer(1);
            });

            Task.Factory.StartNew(() =>
            {
                GetDataFromServer(2);
            });

            Task.Factory.StartNew(() =>
            {
                GetDataFromQueue();
            });

            //Send first signal to get first set of data from server 1 and server 2
            manualResetEvent.Set();
            manualResetEvent.Reset();

            Thread.Sleep(TimeSpan.FromSeconds(2));
            //Send second signal to get second set of data from server 1 and server 2
            manualResetEvent.Set();

            Thread.Sleep(1000);

            ConsoleWriteLine("Just before ReadLine");
            _ = Console.ReadLine(); // wait here until all threads are completed

            /* Result
                * I get first data from server1
                * I get first data from server2
                * I get second data from server1
                * I get second data from server2
                * All the data collected from server2
                * All the data collected from server1
                */
        }

        private static void GetDataFromQueue()
        {
            ConsoleWriteLine("Retrieving data from queue");
            Thread.Sleep(500);
            ConsoleWriteLine("All data from retrieved from queue");
        }

        static void GetDataFromServer(int serverNumber)
        {
            //Calling any webservice to get data
            ConsoleWriteLine("I get first data from server" + serverNumber);
            manualResetEvent.WaitOne();

            Thread.Sleep(TimeSpan.FromSeconds(2));
            ConsoleWriteLine("I get second data from server" + serverNumber);
            manualResetEvent.WaitOne();
            ConsoleWriteLine("All the data collected from server" + serverNumber);
        }

        private static void ConsoleWriteLine(string message)
        {
            var now = DateTime.Now.ToString();
            Console.WriteLine($"{now}: {message}");
        }
    }
}
