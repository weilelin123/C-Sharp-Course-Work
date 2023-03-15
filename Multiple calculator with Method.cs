using System;
using System.Runtime.InteropServices;
using System.Threading.Channels;

namespace MyApp 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x;
            double y;
            double result;

            Console.WriteLine("Please enter number 1: ");
            x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please enter number 2: ");
            y = Convert.ToDouble(Console.ReadLine());

            result = Multiply(x, y);
            Console.WriteLine("The result is : " + result);
        }

        public static double Multiply(double x, double y) //Method
        {
            double z = x * y;
            return z;
        }
    }
}
