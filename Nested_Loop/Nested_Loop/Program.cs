using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nested_Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Hello Abdenbi");
                for(int j = 0; j < 2; j++)
                {
                    Console.WriteLine("\t hello world");
                }
                Console.WriteLine("\n");
            }
            Console.WriteLine("-----------------Exercice---------------");
            for(int xi = 1; xi <= 5; xi++)
            {
                for(int xj = 1; xj <= 10; xj++)
                {
                    Console.WriteLine("{0} x {1}", xi, xj + "=" + (xi * xj));
                }
                Console.WriteLine("\n");
            }

            Console.ReadKey();
        }
    }
}
