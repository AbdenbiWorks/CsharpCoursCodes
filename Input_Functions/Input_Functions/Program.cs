using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Input_Functions
{
    class Program
    {
        static void Main(string[] args)
        {
            ////ReadLine ,Read;
            //string myName ;
            //int myVar1, myVar2;

            ////FOR STRING INPUT

            //Console.WriteLine("your name :");
            //myName = Console.ReadLine();
            //Console.WriteLine($"Helle {myName} \n");

            ////FOR NUMBERS INPUT

            //Console.WriteLine("Enter Your First Number :");
            //myVar1 = Convert.ToInt16(Console.ReadLine());
            //Console.WriteLine($"Your First Variable is : {myVar1} \n");

            //Console.WriteLine("Enter Your Entry");
            //myVar2 = Console.Read(); //ASCII CODE
            //Console.WriteLine($"Your Entry Is : {myVar2}");

            Console.WriteLine("\n \n---------------------Exercice-------------------\n \n");

            /* Q19: Define 4 Variables
                    1- First Name
                    2- Last Name
                    3- Salary
                    4- TaxRate
                    5- Enter All these values from the console window and then Find the salary for 12Month
                       And Print the salary in this form:
                       Welcome fName, lName
                       Your Salary For 12 months is #$
                       You paid TaxRate for 12 Months #$
                       GOOD BYE
            */

            string fName, lName;
            double Salary, TaxRate;
            

            Console.WriteLine("Please Enter Your First Name : ");
            fName = Console.ReadLine();

            Console.WriteLine("\nPlease Enter you Last Name : ");
            lName = Console.ReadLine();

            Console.WriteLine("Enter you Salary Here Please : ");
            Salary = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter you TaxRate Here Please : ");
            TaxRate = Convert.ToDouble(Console.ReadLine());

            Salary = Salary * 12;
            TaxRate = TaxRate * 12;

            Console.WriteLine($"Welcome {fName}, {lName}\nYour Salary For 12 months is {Salary} \nYou paid TaxRate for 12 Months {TaxRate} \nGOOD BYE");

            Console.ReadKey();
        }
    }
}
