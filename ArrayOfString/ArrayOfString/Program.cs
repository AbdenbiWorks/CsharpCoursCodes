using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayOfString
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] myFullName = { "Abdenbi", "Ouammou" };
            int myArraylenght = myFullName.Length;

            for (int i =0; i < myArraylenght; i++)
            {
                Console.Write($"{myFullName[i]} ");

            }
            Console.WriteLine($"\n{myArraylenght}");
            Console.ReadKey();
        }
    }
}
