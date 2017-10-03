using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Break_Loop_BreakCommand
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i =0; i<= 5; i++)
            {
                Console.WriteLine("Hello Abdenbi");
                if (i > 2)
                    break;
                for(int j = 0; j <= 4; j++)
                {
                    Console.WriteLine("\t Hello World");
                }
                Console.WriteLine("\n");

            }

            Console.WriteLine("\n-----------------------Exercice---------------------\n");
            for(int xi = 1;xi <= 1; xi++)
            {
                for(int jx = 1; jx <= 10;jx++ )
                {
                    Console.WriteLine(xi + " x " + jx + " = " + (xi * jx));
                    if(jx == 7)
                    {
                        break;
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
