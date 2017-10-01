using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            double mySalary = 1020.30, total = 0.0;

            while (i < 15)
            {
                total += mySalary;
                i++;

            }
            Console.WriteLine("My Salary is {0}", total);


            int myWeight = 120, desiredWeight = 83, ix = 0;
            int losePerExercise = 1;
            while (myWeight > desiredWeight)
            {

                myWeight = myWeight - losePerExercise;
                ix++;
            }
            Console.WriteLine("Number of exercice is {0} : ",ix);

            Console.ReadKey();
            

            //Q1 Find how many exercice we need to reach 83kg if your wheight was 120kg and
            // each Exercice will make you lose 1kg and print result


        }
    }
}
