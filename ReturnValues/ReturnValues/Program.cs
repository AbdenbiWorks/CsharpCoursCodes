using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReturnValues
{
    class Program
    {
        static int MinValue(int[] myArray)
        {
            int minVal = myArray[0];
            for (int i = 0; i < myArray.Length; i++)
            {
                if (myArray[i] < minVal)
                {
                    minVal = myArray[i];
                }
            }
            return minVal;
        }

        static double AverageStudent(double[] avrgArray)
        {
            double avrgVal = 0.0d;
            for (int i = 0;i < avrgArray.Length; i++)
            {
                avrgVal = (avrgVal + avrgArray[i] / 7);
            }
            return avrgVal;

        }
        static void Main(string[] args)
        {
            int[] myArray = { 11, 5, 8, 6, 4, 15, 6, 84, 55, 99, 3, 5 };
            int minVal = MinValue(myArray);
            Console.WriteLine($"The minimum value in myArray is {minVal}");

            Console.WriteLine("---------------Exercice---------------");
            //Q26 Define a function to find the avarage
            //of a student that has 7grades and print the result in the void maind

            double[] avrgArray = {45, 1, 54, 55, 41, 5, 54 };
            double avrgVal = AverageStudent(avrgArray);
            Console.WriteLine($"The Average for 7 grades = {avrgVal} ");
            Console.ReadKey();
        }
    }
}
