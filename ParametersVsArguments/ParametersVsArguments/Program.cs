using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParametersVsArguments
{
    class Program
    {
        static void addNumbers(int myFirstNumber,int mySecondNumber)
        {
            int temp = myFirstNumber + mySecondNumber;
            Console.WriteLine($"{temp}");
        }

        static int addNumbers2(int myFirstNumber, int mySecondNumber)
        {
            int temp = myFirstNumber + mySecondNumber;
            return temp;
        }
        static void Main(string[] args)
        {
            int myVar1 = 5, myVar2 = 3, temp;
            addNumbers(myVar1, myVar2);

            temp = addNumbers2(myVar1, myVar2);
            Console.WriteLine($"{temp}");
            Console.ReadKey();
        }
    }
}
