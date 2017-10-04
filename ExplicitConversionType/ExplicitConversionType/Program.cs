using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExplicitConversionType
{
    class Program
    {
        static void Main(string[] args)
        {
            //Type1 = (Type1)Type2                      //Casting

            byte mySByte;
            int myInt = 7;
            // mySByte = myInt;
            mySByte = (byte)myInt;

            Console.WriteLine($"My Variable Int = {myInt}" + "\n");
            Console.WriteLine($"My Byte Variable = {mySByte}");
            Console.ReadKey();
        }
    }
}
