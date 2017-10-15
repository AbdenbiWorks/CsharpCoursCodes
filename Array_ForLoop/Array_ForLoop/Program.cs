using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_ForLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            const int myArraySize = 5;  //We Have to use Variable Const if we need to put it in array Numbers Number 3
            int[] myNumbers = { 1, 2, 3, 4, 5 };
            int[] myNumbers2 = new int[myArraySize];
            int[] myNumbers3 = new int[myArraySize] { 1, 5, 1, 5, 89 };

            for(int i = 0; i<5; i++)
            {
                Console.WriteLine(myNumbers[i]);
            }

            Console.WriteLine($"{myNumbers3[1]}");
            //Q22 : Define an array of int type and find the max value
            int[] myExercice = new int[5];
            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine("Please Enter Number {0} :", i);
                myExercice[i] = Convert.ToInt32(Console.ReadLine());
            }
            int maxValue = myExercice.Max();
            Console.WriteLine("Max Value is :{0}",maxValue);

            Console.ReadKey();

        }
    }
}
