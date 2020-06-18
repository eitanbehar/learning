using RestSharp;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Threading
{
    class TaskFactoryExample
    {
        public static void DoSomething()
        {
            var task = Task.Factory.StartNew<string>
                    (() => GetPosts("https://jsonplaceholder.typicode.com/posts"));
            try
            {
                Console.WriteLine(task.Result);
            }
            catch(AggregateException aggEx)
            {
                Console.WriteLine(aggEx.Message);
            }
            _ = Console.ReadLine();
        }

        private static string GetPosts(string v)
        {
            var client = new RestClient("https://jsonplaceholder.typicode.com/posts")
            {
                Timeout = -1
            };
            var request = new RestRequest(Method.GET);
            IRestResponse response = client.Execute(request);
            return response.Content;
        }
    }
}
