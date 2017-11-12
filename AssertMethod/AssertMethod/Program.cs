using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using System.Diagnostics;

namespace AssertMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Enter a value");
            int i = Convert.ToInt32(Console.ReadLine());
            if(i >= 0)
            {
                Console.WriteLine($"{i}");
            }
            else
            {
                Debug.WriteLine("We Are Here");
                Debug.Assert(i >= 100, "Short", "Long");
            }
            WriteLine("Done");
            ReadKey();
        }
    }
}
