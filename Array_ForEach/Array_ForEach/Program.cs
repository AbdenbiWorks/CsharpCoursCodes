using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_ForEach
{
    class Program
    {
        static void Main(string[] args)
        {
            const int myArraySize = 5;
            int[] myNumbers3 = new int[myArraySize] { 1, 5, 8, 9, 7 };

            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine("My numbers " + (i + 1) + "= " + $"{myNumbers3[i]}" + " ");
            }
            foreach(int item in myNumbers3)
            {
                Console.WriteLine("My number " + "= " + $"{item}");
            }

            //Define an Array of 15 elements and use foreach to iterate 14 elements only

            int[] myExercice = new int[4] {1,5,7,4 };
            int j = 0;
            foreach(int items in myExercice)
            {
                Console.WriteLine("My Numbers" + $"{items}");
                j++;
                if (j >= 3)
                    break;
            }

            Console.ReadKey();
        }
    }
}
