using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringSplit
{
    class Program
    {
        static void Main(string[] args)
        {
            string myString;
            char[] separator = { ' ' };
            myString = Console.ReadLine();
            string[] myNewWords;
            myNewWords = myString.Split(separator);
            foreach(string word in myNewWords)
            {
                Console.WriteLine($"{word}");
            }
            Console.ReadKey();
        }
    }
}
