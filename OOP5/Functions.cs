using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP5
{
    class Functions
    {
        public static void Tabulate(
            double start, double finish, double increase, MyFunc func)
        {
            for (double x = start; x <= finish; x += increase)
            {
                Console.WriteLine($"y = {func(x)}");
            }
        }
        public static double Func2(double x)
        {
            return Math.Sqrt(6 * Math.Pow(x, 2) - 1);
        }
        public static double Func3(double x)
        {
            //double jeff = 3 + x;
            //double jeff1 = 0.1 * x;
            //double jeff2 = Math.Pow(x, jeff);
            return (0.5 * Math.Pow(x, 3 + x)) + (0.1 * x);
        }

    }
}
