using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignement_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            // =, +=, *=, /=, %=

            int myVar1 = 7, myVar2 = 2;

            //myVar1 = myVar2;
            //myVar1 += myVar2; // ==> myVar1 = myVar1 + myVar2
            //myVar1 -= myVar2; // ==> myVar1 = myVar1 - myVar2
            //myVar1 /= myVar2; // ==> myVar1 = myVar1 / myVar2
            //myVar1 *= myVar2; // ==> myVar1 = myVar1 * myVar2
            //myVar1 %= myVar2; // ==> myVar1 = myVar1 % myVar2

            myVar1 /= ++myVar2;
            Console.WriteLine("The value of myVar1 = " + myVar1);
            Console.WriteLine("The value of myVar2 = " + myVar2);
            Console.WriteLine("------------------------Exercice-------------------------");

            /*
              
             Q1 / What's the result of this expression
                  int temp, myVar1 = 7, myVar2 = 2;

                 myVar1 /= ++myVar2;
                        and why?
             
              
             */

            Console.ReadKey();
        }
    }
}
