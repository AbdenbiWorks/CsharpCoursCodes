using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nested_If_Statement2
{
    class Program
    {
        static void Main(string[] args)
        {
            int myVar = 4, myVar2 = 6;
            if(myVar <= 3 && myVar2 >= 5)
            {
                Console.WriteLine("Consdition One is right");
            }
            else if(myVar <= 4 && myVar2 >= 6)
            {
                Console.WriteLine("Condition Two is right");
            }
            else if (myVar2 > 5)
            {
                Console.WriteLine("Condition Three right");
            }
            else
            {
                Console.WriteLine("No One of the Conditions");
            }
            Console.ReadKey();
        }
    }
}
