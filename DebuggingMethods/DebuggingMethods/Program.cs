using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using System.Diagnostics;

namespace DebuggingMethods
{
    class Program
    {
        public static int addFunction(int x, int y)
        {
            Debug.WriteLine("We Started are here in the add Function");
            int z = x + y;
            Debug.WriteLine("We are done here int the Add Function");
            Trace.WriteLine("We are done here int the Add Function");
            return z;
        }
        public static int MulFunction(int x, int y)
        {
            Debug.WriteLine("We are started here in the Mult Function");
            int z = x * y;
            Debug.WriteLine("We are done here in the Mult Function");
            return z;
        }

        public static void WriteFunction(int z)
        {
            Debug.WriteLine("We are started here in the write Function");
            WriteLine($"{z}");
            Debug.WriteLine("We done here in the write Function");
        }
        static void Main(string[] args)
        {
            int myNum, myVar1 = 4, myVar2 = 7;

            myNum = addFunction(myVar1, myVar2);
            WriteFunction(myNum);
            myNum = MulFunction(myVar1, myVar2);
            WriteFunction(myNum);
            Console.ReadKey();
        }
    }
}
