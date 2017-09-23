using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Literal_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            int myVar = -100;
            uint myUVar = 1000;

            float myFlVar = 1.5F; //You Have To Use The Letter To Not Refuse Tha Value
            double myDVar = 100.5;
            decimal myDecVar = 100.5M; //The Same Thing That we Said In Float Variable

            Console.WriteLine("{0} {1} {2} {3} {4}", myVar, myUVar, myFlVar, myDVar, myDecVar);
            Console.ReadKey();
        }
    }
}
