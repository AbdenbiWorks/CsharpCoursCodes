using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            int mySalary = 1000, total = 0;
            for(int i = 0;i < 12; i++)
            {
                total += mySalary;
            }
            Console.WriteLine("My salary for 12 months is {0}", total);
            Console.ReadKey();
        }
    }
}
