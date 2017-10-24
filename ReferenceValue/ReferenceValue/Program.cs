using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReferenceValue
{
    class Program
    {
        static void MultiplyNum(ref int myVar)
        {
            myVar *= 3;
            Console.WriteLine($"my number = {myVar}");
        }

        static void MultiNumbers (ref int myVar1, ref int myVar2)
        {
            myVar1 *= 4;
            myVar2 *= 3;
            Console.WriteLine($"My First multiplied number is= {myVar1}");
            Console.WriteLine($"My Second multiplied number is= {myVar2}");
        }
        static void Main(string[] args)
        {
            int myNumber = 5;
            Console.WriteLine($"my Number = {myNumber}");
            MultiplyNum(ref myNumber);
            Console.WriteLine($"my number = {myNumber}");

            Console.WriteLine("-----------Exercice--------");
            //Q27 define a function that accept two parameters
            // as reference values  and change them using multiplication
            // by 4 and print the result before and after multilplication

            int myNumber1 = 4, myNumber2 = 8;
            Console.WriteLine($"myFirst Number is = {myNumber1}");
            Console.WriteLine($"MySecond Number is = {myNumber2}");
            MultiplyNum(ref myNumber1);
            MultiplyNum(ref myNumber2);
            Console.WriteLine($"My first reference number = {myNumber1}");
            Console.WriteLine($"My Second reference number = {myNumber2}");

            Console.ReadKey();

        }
    }
}
