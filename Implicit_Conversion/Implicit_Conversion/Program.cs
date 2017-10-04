using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implicit_Conversion
{
    class Program
    {
        static void Main(string[] args)
        {
            long myVar = 1000;
            float myVar2 = myVar;
            float myFloatVar = 12.5f;
            int myInt2Var = myFloatVar;


            Console.WriteLine(myVar2);

            char myVar3 = 'G';
            int myIntVar = myVar3;

            Console.WriteLine(myIntVar);
            Console.ReadKey();
        }
    }
}
