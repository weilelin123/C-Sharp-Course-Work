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

            var text = new Text();
            text.Width = 100;
            text.Copy();

            Console.ReadKey();
        }
    }
}