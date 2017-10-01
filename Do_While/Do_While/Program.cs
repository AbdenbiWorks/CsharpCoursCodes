using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Do_While
{
    class Program
    {
        static void Main(string[] args)
        {
            double mySalary = 1000.20, total = 0.0;
            int i = 0;
            do
            {
                total += mySalary; //Total = Total + mySalary;
                i++;
                Console.WriteLine("i values equal {0}", i);

            } while (i < 10);
            Console.WriteLine("Salary Values equal {0}", total);

            int salary = 1020, increment = 20, salarydesired = 2000;
            int j = 0;
            do
            {
                salary += increment;
                j++;

            } while (salary < salarydesired);

            float years = j / 12;
            Console.WriteLine("Nimber Of Month {0}\nNumber of yeears is {1}", j, years);







            //Q1 Find how many years to reach $2000 if your salary was $1020 and the increment percentage
            // was $20 per month and print the result

            Console.ReadKey();
        }
    }
}
