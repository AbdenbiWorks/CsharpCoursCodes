using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TernaryOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            int myVar = 9;

            string myResult = (myVar < 10) ? "less than 10" : "greater than 10"; 
            Console.WriteLine("My Variable result is {0}", myResult);

            string myName = "Abdenbi", result;
            result = (myName.Equals("Abdenbi")) ? "yes" : "no";
            Console.WriteLine("My Variable result is {0}", result);

            Console.ReadKey();
        }
    }
}
