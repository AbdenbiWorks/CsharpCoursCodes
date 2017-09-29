using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nested_If_Statement
{
    class Program
    {
        static void Main(string[] args)
        {
            //int myVar1 = 9, myVar2 = 6;

            //if(myVar1 == 9)
            //{
            //    Console.WriteLine("myVar1 = 9");
            //    if(myVar2 == 7)
            //    {
            //        Console.WriteLine("myVar2 = 7");
            //    }
            //    else
            //    {
            //        Console.WriteLine("myVar2 = 6");
            //    }
            //}


            Console.WriteLine("\n ---------------------Exercice-----------------\n");




            /*
                Q1/ Define 3 Variables myVar1 = 10, myVar2 = 6,myVar3 = 8
                and chek the values using nested if-else-statement

                    1- (myVar1 == 10) print a statement
                    2- ((myVar2 >= 5) && (myVar3 <= 9))
                        and print else for each one of them
                



           */
            int myVar1 = 10, myVar2 = 6, myVar3 = 8;

            if(myVar1 == 10)
            {
                Console.WriteLine("myVar1 = 10");
            }
            else
            {
                if((myVar2 >= 5) && (myVar3 <= 9))
                {
                    Console.WriteLine("myVar2 is great than 5 And myVar3 less than 9");
                }
            }


            Console.ReadKey();
        }
    }
}
