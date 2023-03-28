using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;
using System.Threading.Channels;
using System.Xml.Linq;


namespace MyApp
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            var car = new Car("SRT 556");

            Console.ReadKey();
        }
          
    }
}