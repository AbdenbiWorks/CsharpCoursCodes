using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringType
{
    class Program
    {
        static void Main(string[] args)
        {
            // \' \" \\ \0 \b \n \r \t \v \f This is the escape characters

            // @


            string myString = "This is my string variable";
            string myString2 = "Hassan Said \"This is the best Cours\" ";
            string myString3 = @"C:\Users\Pc\source\repos";
            string myString4 = myString2 + myString3; // Add string to Other

            Console.WriteLine(" {0} \n {1}", myString, myString2);
            Console.WriteLine("{0}", myString3);
            Console.WriteLine("{0}", myString4);

            /*
             
            Q1: How can I use the Character @ instead of the \ in the string to get same result
                "Nazar has said \"This is a unique course \", And i think so";
            Q2: What is the purpose of these escape characters \t \v \f 

             */

            Console.WriteLine("---------------------------- Exercice ------------------------------");

            string Q1 = @"Nazar has said ""This is a unique course"",And i think";
            string Q2 = "\t \v \f";
            Console.WriteLine("This the Answer : {0}", Q2);


            Console.ReadKey();


        }
    }
}
