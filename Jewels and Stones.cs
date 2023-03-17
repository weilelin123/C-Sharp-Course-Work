using System;
using System.Runtime.InteropServices;
using System.Threading.Channels;
using System.Xml.Linq;

/* (This is a question from LeetCode #771. Jewels and Stones) 
 * You're given strings jewels representing the types of stones that are jewels, and stones representing the stones you have. Each character in stones is a type of stone you have. You want to know how many of the stones you have are also jewels.

Letters are case sensitive, so "a" is considered a different type of stone from "A".
 */
namespace MyApp
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            string jewels = "aaaA"; //变量
            string stones = "AaaaA"; //变量
            int count = 0;

            foreach (char s in stones)
            {
                if (jewels.Contains(s))
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}
