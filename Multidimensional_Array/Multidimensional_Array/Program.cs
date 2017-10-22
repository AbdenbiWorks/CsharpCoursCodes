using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multidimensional_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] myNumbers = new int[,]
                            {
                                {1, 2, 3, 4},
                                {2, 3, 4, 5},
                                {3, 4, 5, 6}
                            };
            for(int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 4; j++)
                {
                    Console.Write("{0}", myNumbers[i, j]);
                }
                Console.WriteLine("");
                int[,,] myArray3Da = new int[2, 2, 3]
                {
                    {
                        {1,2,3 },{4,5,6}
                    },
                    {
                        {7,8,9 },{10,11,12}
                    }

                };
            }
            Console.WriteLine("\n ***************Exercice***********\n");
            //Define a 3D Array and print the values using 3 for loop
            int[,,] my3DimensionalAray = new int[3, 2, 3]
            {
                {   {31,52,56 },{15,59,95} },
                {   {8,6,4 },{10,15,16} },
                {   {7,2,6 },{32,23,99} }
            };

            for(int a = 0; a < 3; a++)
            {
                for(int b = 0; b < 2; b++)
                {
                    for(int c = 0;c < 3; c++)
                    {
                        Console.Write("{0}", my3DimensionalAray[a,b,c] +" \t");
                    }
                }
                Console.WriteLine("\t\t");
            }

            Console.ReadKey();
        }
    }
}
