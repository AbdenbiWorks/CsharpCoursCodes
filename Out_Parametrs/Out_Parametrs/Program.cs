using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Out_Parametrs
{
    class Program
    {
        static int MinValue (int[] myArray2,out int myIndex)
        {
            myIndex = 0;
            int minVal = myArray2[0];
            for(int i = 0; i < myArray2.Length; i++)
            {
                if (myArray2[i] < minVal)
                {
                    minVal = myArray2[i];
                    myIndex = i;
                }
            }
            return minVal;
        }
        static void Main(string[] args)
        {
            int myIndex;
            int[] myArray = { 11, 10, 43, 6, 22, 8, 9, 13, 50, 22 };
            int minVal = MinValue(myArray, out myIndex);
            Console.WriteLine($"The minimum value in myArray is {minVal} and the Index is {myIndex}");
            Console.ReadKey();
        }
    }
}
