using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.IO;
using System.Security.AccessControl;

// nested loops = loops inside of other loops
//          uses vary. Used a lot in sorting algorithms


namespace Class
{
    class Program
    {

        public static void Main(string[] args)
        {

            Console.WriteLine("How many rows? :");
            var rows = Convert.ToInt32(Console.ReadLine()); // User input how many rows

            Console.WriteLine("How many columns? :");
            var columns = Convert.ToInt32(Console.ReadLine()); // User input how many columns

            Console.WriteLine("what symbol? :");
            var symbol = Convert.ToString(Console.ReadLine()); // User input what symbol.

            for(int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(symbol);
                }
                Console.WriteLine();
            }

            Console.ReadKey();

        System.Environment.Exit(0);
        }
    }
}