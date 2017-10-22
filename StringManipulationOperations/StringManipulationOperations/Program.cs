using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringManipulationOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            string myString = "Abdenbi Ouammou";
            char[] myCharArray = myString.ToCharArray();
            Console.WriteLine($"My String Lenght is {myString.Length} ");

            foreach (char myChar in myCharArray)
            {
                Console.WriteLine($"{myChar}");
            }

            Console.WriteLine("\n-----------------Exercice-----------------/n");

            //Q25/ Define a strinf variable that assign "I'm Smart"
            //Change the substring "I am" to "He is"

            string myString1 = "I am smart";
            myString1 = myString1.Substring(4);
            myString1 = "He is" + myString1;
            char[] myCharArray1 = myString1.ToCharArray();

            foreach(char myChar1 in myCharArray1)
            {
                Console.WriteLine($"\t\t{myChar1}");
            }

            Console.ReadKey();
        }
    }
}
