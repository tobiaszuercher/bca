using System;
using System.Net.Http;

namespace ConsoleApplication
{
    public class Program
    {
        public static  void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            MainAsync(args).Wait();
        }

        private static async void MainAsync(string[] args)
        {
            var client = new HttpClient();
            
        }
    }
}
