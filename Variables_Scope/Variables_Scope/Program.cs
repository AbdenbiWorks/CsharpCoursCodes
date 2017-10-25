using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables_Scope
{
    class Program
    {
        static string myString;
        static void PrintMyString()
        {
            string myString = "my string inside the printmyString method";
            Console.WriteLine($"{myString}");
            Console.WriteLine($"{Program.myString}");
        }
        static void Main(string[] args)
        {
            string myString = "my string inside the main method";
            Program.myString = "Global my String Variable";
            PrintMyString();
            Console.WriteLine($"{myString}");
            Console.WriteLine($"{Program.myString}");
            Console.ReadKey();
        }
    }
}
