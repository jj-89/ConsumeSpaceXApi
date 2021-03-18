using Newtonsoft.Json.Linq;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace ConsumeSpaceXApi
{
    class Program
    {
        private static readonly HttpClient HttpClient;

        static Program()
        {
            HttpClient = new HttpClient();
        }

        static async Task Main(string[] args)
        {
            Console.WriteLine("Hello World");
        }

    }
}
