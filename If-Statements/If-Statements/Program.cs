using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace If_Statements
{
    class Program
    {
        static void Main(string[] args)
        {
            int myVar = 10;


            if(myVar == 10)
            {
                Console.WriteLine("My Variable id Equal 10");
            }
            else
            {
                Console.WriteLine("My Variable Is not Equal 10");
            }


            int myVar2 = 9;
            int myVar3 = 3;


            if (( myVar2 <= 7) || ( myVar3 == 3))
            {
                Console.WriteLine("My Var2 is Less than 7 and myVar3 equal 3");
            }
            else
            {
                Console.WriteLine("Wana Malii");
            }


            Console.ReadKey();
        }
    }
}
