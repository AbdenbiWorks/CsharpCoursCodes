using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Increments_Decrements
{
    class Program
    {
        static void Main(string[] args)
        {
            int myVar1 = 2;
            int temp1 = myVar1++;

            /*
                            Cas1 : ++myVar1 first increments the value of a and then returns an lvalue referring to a, so if the value of a is used then it will be the incremented value.
                            Cas2 : myVar1++ first returns an rvalue whose value is a, that is, the old value, and then increments a at an unspecified time before the next full-expression
                                    (i.e., "before the semicolon")
            */

            Console.WriteLine();
        }
    }
}
