using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums_Variables
{
    class Program
    {
        enum humanSex :sbyte
        {
            male = 1,
            female =2
        }

        enum orination : sbyte
        {
            north = 2,
            south = 3,
            west = 4,
            east = 5
        }
        static void Main(string[] args)
        {
            sbyte humanSbyte;
            string humanGender;

            humanSex myhumanSex = humanSex.male;
            Console.WriteLine($"Human Sex = {myhumanSex}" + "\n");

            humanSbyte = (sbyte)myhumanSex;
            humanGender = Convert.ToString(myhumanSex);

            Console.WriteLine($"Human Gender index in = {humanSbyte}" + "\n");
            Console.WriteLine($"Human Associad with this index = {humanGender}" + "\n");



            //Exercice


            orination nor = orination.north;
            orination soth = orination.south;
            orination wst = orination.west;
            orination est = orination.east;
            Console.WriteLine(nor);
            Console.WriteLine(soth);
            Console.WriteLine(wst);
            Console.WriteLine(est);
            sbyte num;
            num = (sbyte)nor;
            Console.WriteLine($"north asossiated with index {num}");

            Console.ReadKey();

        }
    }
}
