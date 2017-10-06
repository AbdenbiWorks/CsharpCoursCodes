using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Explicit_Conversion_Using_Convert_Command
{
    class Program
    {
        static void Main(string[] args)
        {
            double myDoubleVar = 1500.50D;
            string myStringVar, mySubString;

            //myStringVar = myDoubleVar;            //Implicit Conversion

            myStringVar = Convert.ToString(myDoubleVar);

            mySubString = myStringVar.Substring(0,2); //Text from index 0 and pick two character That's Mean in 1500.5 He Will take 1 and 5

            Console.WriteLine($"My Variable is {myDoubleVar}\n");
            Console.WriteLine("my String Variable is {0} \n", myStringVar);
            Console.WriteLine("My String Variable is {0} \n", mySubString);

            Console.WriteLine("------------------------Exercice--------------------------");

            //Q18/ Define a float variable and assigne the value 45.56 and convert it to string
            // And print the numbers start from the float point

            float myFloatVar = 14.56f;
            string myStringVar2, mySubString2;

            myStringVar2 = Convert.ToString(myFloatVar);
            mySubString2 = myStringVar2.Substring(3,2);

            Console.WriteLine($"My Variable is {myStringVar2}\n");
            Console.WriteLine($"My Variable is {mySubString2}\n");



            Console.ReadKey();
        }
    }
}
