using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            string myAnimel = "Cat";

            switch (myAnimel)
            {
                case "Canary":
                    Console.WriteLine("My Animal is the canary bird");
                    break;
                case "Cat":
                    Console.WriteLine("My animal is a cat");
                    break;
                case "Camel":
                    Console.WriteLine("My animal is a camel");
                    break;
                default:
                    Console.WriteLine("No one");
                    break;
            }

            int myVar = 15;

            switch (myVar)
            {
                case 10:
                    Console.WriteLine("My variable number value is 10");
                    break;
                case 7:
                    Console.WriteLine("My Variable Number value is 7");
                    break;
                case 4:
                    Console.WriteLine("My Variable Number value is 4");
                    break;
                default:
                    Console.WriteLine("No One");
                    break;
            }


            Console.WriteLine("\n --------------------------Exercice-----------------\n");

            //Challange 10
            //Define a string variable whatHeSay and assign the value "Hello" and check what the variable
            //Value among these cases "hello", "Bye", "welcome" or NoOne is the default and print the result
            //And Why?

            string whatHeSay = "Hello";

            switch (whatHeSay)
            {
                case "hello":
                    Console.WriteLine("He Said hello");
                    break;
                case "Bye":
                    Console.WriteLine("He said Bye");
                    break;
                case "welcome":
                    Console.WriteLine("He Said welcome");
                    break;
            }

            Console.ReadKey();
        }
    }
}
