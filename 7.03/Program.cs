using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._03
{
    internal class Program
    {
        static double pole(double r)
        {
            return Math.PI * r * r;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("podaj promien kola:");
            double r = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"pole kola o promieniu {r} to: " + pole(r));
            Console.ReadKey();
        }
    }
}
