using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.IO;
using System.Security.AccessControl;

namespace Class
{
    class Program
    {

        public static void Main(string[] args)
        {

            //Logical operators = Can be used to check if more than 1 condition is true/false.
            // && (AND)
            // || (OR)

            Console.WriteLine("What's the temperature ouside: (C)");
            double temp = Convert.ToDouble(Console.ReadLine());

            if(temp >= 10 && temp <= 30)
            {
                Console.WriteLine("It's Warm outside!");
                Console.WriteLine("Let's go grab a drink!!");
            }
            else if (temp <= - 50 || temp >= 50)
            {
                Console.WriteLine("Don't go out!!!");
            }

        Console.ReadKey();

        System.Environment.Exit(0);
        }
    }
}