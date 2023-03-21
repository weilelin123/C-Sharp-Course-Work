using System;

namespace MyApp
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            var cookie = new HttpCookie();
            cookie["name"] = "test";
            Console.WriteLine(cookie["name"]);


            Console.ReadKey();
        }
    }
}