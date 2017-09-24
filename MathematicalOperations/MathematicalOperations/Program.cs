using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathematicalOperations
{
    class Program
    {
        static void Main(string[] args)
        {

            // + * / - %

            int myVar1 = 10;
            int myVar2 = 5;

            int temp = myVar1 + myVar2;
            int temp2 = myVar1 - myVar2;
            int temp3 = myVar1 % myVar2;

            // + -
            int myNegativeVar = -10;
            int temp4 = +myNegativeVar;

            string myStr = "This is wonderfl";
            string myStr2 = " How is it?";
            myStr = myStr + myStr2;

            Console.WriteLine(myStr);
            Console.WriteLine("The result is {0} \n The result2 is {1} \n The remaining is {2}", temp, temp2, temp3);


            Console.WriteLine("--------------------------------- Exercice ------------------------------------");
            /*
             Q1 / Define 2 Variable var1 = 7, var2 = 3 and apply the operator (+, -, /, *, %)
             Q2 / Define 2 string variable and sum both to get I am smart;
             */

            int var1 = 7;
            int var2 = 3;

                int Q1 = var1 + var2;
                Console.WriteLine(" var1 + var2 = " + Q1);

                Q1 = var1 - var2;
                Console.WriteLine(" var1 - var2 = " + Q1);

                Q1 = var1 * var2;
                Console.WriteLine(" var1 * var2 = " + Q1);

                Q1 = var1 / var2;
                Console.WriteLine(" var1 / var2 = " + Q1);

                Q1 = var1 % var2;
                Console.WriteLine(" var1 % var2 = " + Q1);

            Console.ReadKey();

        }
    }
}
