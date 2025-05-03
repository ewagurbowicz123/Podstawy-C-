using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._02
{
    internal class Program
    {
        static double max(double a, double b)
        {
            if (a > b)
                return a;
            else
                return b;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("podaj a:");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("podaj b:");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"max z {a} i {b} to: " + max(a, b));
            Console.ReadKey();
        }
    }
}
