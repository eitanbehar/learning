using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Threading
{
    class LockExample
    {
        public static void DoSomething()
        {

            Random rnd = new Random();

            List<Task> lotOfTasks = new List<Task>();
            var account = new Account(20000);
            for (int i = 0; i < 1000; i++)
            {
                lotOfTasks.Add(new Task(() => account.Withdraw(rnd.Next(2000,5000))));
            }

            lotOfTasks.ForEach(t => t.Start());

            Task.WaitAll(lotOfTasks.ToArray());

            _ = Console.ReadKey();

        }

        class Account
        {
            private int _balance;
            private readonly object lockBalance = new object();

            public Account(int initialBalance)
            {
                _balance = initialBalance;
            }

            public int Withdraw(int amount)
            {
                lock (lockBalance)
                {
                    Thread.Sleep(200);

                    if (_balance < 0)
                    {
                        throw new Exception("Balance is negative, you cannot withdraw");
                    }
                    if (_balance >= amount)
                    {
                        _balance -= amount;
                        Console.WriteLine("Balance: " + _balance);
                        return _balance;
                    }
                    else
                    {
                        Console.WriteLine("Cannot withdraw");
                        return 0;
                    }     
                }            
            }
            
        }

    }
}
