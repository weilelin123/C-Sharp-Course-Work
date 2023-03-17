using System;
using System.Runtime.InteropServices;
using System.Threading.Channels;
using System.Xml.Linq;


namespace MyApp
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer(1);
            customer.Orders.Add(new Order());
            customer.Orders.Add(new Order());

            customer.Promote();

            Console.WriteLine(customer.Orders.Count);


            Console.ReadKey();
        }
    }
}
