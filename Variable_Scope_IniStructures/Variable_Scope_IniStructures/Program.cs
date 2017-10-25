using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variable_Scope_IniStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            for (i = 0; i < 10; i++)
            {
                int index = i;
                Console.WriteLine($"{index}");

            }
            Console.WriteLine($"Last index output in loop : {index}"); //You have to declare the index variable and defined him
            Console.ReadKey();
        }
    }
}
