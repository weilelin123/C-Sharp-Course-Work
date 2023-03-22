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
            String[,] parkingLot = { { "Mustang", "F-150", "Explorer" },
                                     { "Corvette", "Camaro", "Silverado" },
                                     { "Corolla", "Camry", "Rav4" }
                                   };

            for(int i = 0; i < parkingLot.GetLength(0); i ++)
            {
                for (int j = 0; j < parkingLot.GetLength(1); j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
           }
            

            Console.ReadKey();
        }
    }
}