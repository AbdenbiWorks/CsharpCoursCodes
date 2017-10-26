using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructFunctions
{
    class Program
    {
        struct FullName
        {
            public string myFirstName, myLastName;
            public string printName() => myFirstName + " " + myLastName;
        }
        static void Main(string[] args)
        {
            FullName myFullName;
            myFullName.myFirstName = "Abdenbi";
            myFullName.myLastName = "Ouammou";
            //Console.Write($"{myFullName.myFirstName} {myFullName.myLastName}");
            Console.Write($"{myFullName.printName()}");
            Console.ReadKey();
        }
    }
}
