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
        }
    }
}
