using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structure_Type
{
    class Program
    {
        enum toyota : byte
        {
            RAV4        =1,
            Camery      =2,
            Tundra      =3,
            HighLand    =4
        }
        struct carType{
            public toyota modelName;
            public double modelYear;
        }

        //Exercice
        enum orientaion : byte
        {
            north = 1,
            south = 2,
            west = 3,
            east = 4
        }

        struct direction
        {
            public orientaion oritentName;
            public double myDistance;
        }
        static void Main(string[] args)
        {
            carType myCarType;
            int carType = -1;
            double modelYear;
            Console.WriteLine("1) RAV4\n2) Camery\n3) Tundra\n4) HighLand");
            do
            {
                Console.WriteLine("Enter Your Car Type:");
                carType = Convert.ToInt32(Console.ReadLine());
            }
            while ((carType < 1) || (carType > 4));

            Console.WriteLine("Inout Model Year :");
            modelYear = Convert.ToDouble(Console.ReadLine());
            myCarType.modelName = (toyota)carType;
            myCarType.modelYear = modelYear;
            Console.WriteLine($"My Car Type is {myCarType.modelName}" +$"And the model year is {myCarType.modelYear}");

            Console.WriteLine("\n-----------------Exercice---------------------\n");
            // Exercice
            int myDistanation = -1;
            double myDistance;
            Console.WriteLine("1) North \n2) South\n3) West\n4) East");
            do
            {
                Console.WriteLine("Enter your Destination Type");
                myDistanation = Convert.ToInt32(Console.ReadLine());
            }
            while ((myDistanation < 1) || (myDistanation > 4));

            Console.WriteLine("Input the distance :");
            myDistance = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Your Destination type is {0}\n And Your distance is: {1}", myDistanation, myDistance);
            Console.ReadKey();


            //Q21 Define a struct that contains the directions by the orientation
            // as a enum the distance to reach a destination
            // And Print the direction and that distance
        }
    }
}
