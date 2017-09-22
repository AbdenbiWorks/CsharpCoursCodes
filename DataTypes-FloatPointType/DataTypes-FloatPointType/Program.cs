using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes_FloatPointType
{
    class Program
    {
        static void Main(string[] args)
        {
            float flMin = float.MinValue;
            float flMax = float.MaxValue;

            Console.WriteLine("Min value = {0} Max Value = {1}",flMin, flMax);

            float flVar = 1F / 3;
            double dlVar = 1D / 3;
            decimal dcVar = 1M / 3;

            Console.WriteLine(" Float Value = {0}\n Double Value = {1}\n Decimal Value = {2}", flVar, dlVar, dcVar);
            Console.ReadKey();
        }
    }
}
