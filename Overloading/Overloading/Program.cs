using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overloading
{
    class Program
    {
        public static double MinValue(double[] Numbers)
        {
            double minValue = Numbers[0];
            for(int i = 0; i < Numbers.Length; i++)
            {
                if(Numbers[i]  < minValue)
                {
                    minValue = Numbers[i];
                }
            }
            return minValue;
        }

        public static int MinValue(int[] Numbers)
        {
            int minValue = Numbers[0];
            for (int i = 0; i < Numbers.Length; i++)
            {
                if (Numbers[i] < minValue)
                {
                    minValue = Numbers[i];
                }
            }
            return minValue;
        }
        public static int printNumber(int myNumber)
        {
            return myNumber;
        }
        public static double printNumber(double myNumber)
        {
            return myNumber;
        }
        static void Main(string[] args)
        {
            int myNumber = 9;
            Console.Write($"{printNumber(myNumber)}");
            //Q29
            //Define two function using overloading concepts to return the minimum value once
            //as integer and once as double value and print the result

            int[] Numbers = { 10, 5, 9, 6, 1, 3, 15, 75, 78, 8 };
            Console.Write($"The minimum value in the array is = {MinValue(Numbers)}");
            Console.ReadKey();

            
            
        }
    }
}
