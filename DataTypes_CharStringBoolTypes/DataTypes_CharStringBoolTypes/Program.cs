using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes_CharStringBoolTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            int charMin = char.MinValue;
            int charMax = char.MaxValue;

            char myVar = 'G';
            int myVarValue = 'G';

            char myVarValue2 = Convert.ToChar(myVar);

            Console.WriteLine(" Min Char = {0}\n Max Char = {1}\n My Character = {2}\n My Variable Code ASCII = {3}\n Convert My Variable To Char = {4}",
                charMin, charMax, myVar, myVarValue, myVarValue2);

            string myString = "This is my variable";
            Console.WriteLine("My string is = {0}", myString);

            bool myBool = true;
            Console.WriteLine("My Boolean value is = {0}", myBool);

            Console.WriteLine("\n \n----------------Exercice---------------- \n \n");

            /*
                
                Q1/ Define a variable that can accept the 'A' character value and print that number value on the console screen?
                Q2/ Define a variable that can accept the 'a' character value and print that number value on the console screen?  
                Q3/ Dafine a string variable and assigne the statement "This is my character A value
                Q4/ Dafine a string variable and assigne the statement "This is my character a value
            */

            int variableQ1 = 'A';
            int variableQ2 = 'a';

            Console.WriteLine(" Q1 : Number of value A = {0} \n Q2 : Number of value a = {1}", variableQ1, variableQ2);

            string variableQ3 = "This is my character A value";
            string variableQ4 = "This is my character a value";

            Console.WriteLine(" Q3 : My string Variable  = {0} \n Q4 : My string Variable  = {1}", variableQ3, variableQ4);

            Console.ReadKey();
        }
    }
}
