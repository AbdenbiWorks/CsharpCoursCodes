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
            Console.ReadKey();
        }
    }
}
