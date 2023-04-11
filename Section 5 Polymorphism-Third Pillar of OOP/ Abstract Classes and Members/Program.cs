using System;
using System.Collections;
using System.ComponentModel.DataAnnotations;
using System.Formats.Tar;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Threading.Channels;
using System.Xml.Linq;


namespace MyApp
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            var circle = new Circle();
            circle.Draw();

            var rectangle = new Rectangle();
            rectangle.Draw();

            Console.ReadKey();
        }

        public class Rectangle : Shape
        {
            public override void Draw()
            {
                Console.WriteLine("Draw a rectangle.");
            }
        }
    }
}