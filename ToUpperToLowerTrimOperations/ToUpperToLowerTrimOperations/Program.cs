using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToUpperToLowerTrimOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            string myString, myString2;
            //myString = Console.ReadLine();

            //myString2 = myString.ToLower();
            //Console.WriteLine($"{myString2}");

            //myString2 = myString.ToUpper();
            //Console.WriteLine($"{myString2}");

            char[] mytromChar = { 'h', 'e', 'i', ' ' };
            Console.WriteLine("Please Enter Your Text");
            myString = Console.ReadLine();
            myString = myString.ToLower();
            myString2 = myString.Trim(mytromChar);
            Console.WriteLine($"{myString2}");

            //myString2 = myString.Trim();
            //Console.WriteLine($"{myString2}");


            Console.ReadKey();
        }

    }
}
