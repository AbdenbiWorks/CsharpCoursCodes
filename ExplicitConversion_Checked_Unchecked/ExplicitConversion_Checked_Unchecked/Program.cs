using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExplicitConversion_Checked_Unchecked
{
    class Program
    {
        static void Main(string[] args)
        {
            //Type1 = (Type1) Type2                         //Casting

            byte mySbyte;
            int myInt = 350;

            mySbyte = (byte)myInt;

            Console.WriteLine($"My Variable Int = {myInt}" + "\n");
            Console.WriteLine($"My byte Variable = {mySbyte}");
            Console.WriteLine("------------------------------Exerceice-------------------------");

            decimal myDecVar = 102524;
            int Q17 = checked((int) myDecVar);

            Console.WriteLine(Q17);



            Console.ReadKey();

            //Q17/ Define a Decimal variable and than convert it to an Integer using
            //Either Implicit or Explicit conversion operations and use checked keyword to throught
            // an exception of overflow type
        }
    }
}
