using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("Podaj a: ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Podaj b: ");
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Podaj c: ");
            c = Convert.ToInt32(Console.ReadLine());

            if (a > b && a > c)
            {
                Console.WriteLine($"{a} jest największa");
            }
            else if (b > a && b > c)
            {
                Console.WriteLine($"{b} jest największa");
            }
            else
            {
                Console.WriteLine($"{c} jest największa");
            }

            if (a < b && a < c)
            {
                Console.WriteLine($"{a} jest najmniejsza");
            }
            else if (b < a && b < c)
            {
                Console.WriteLine($"{b} jest najmniejsza");
            }
            else
            {
                Console.WriteLine($"{c} jest najmniejsza");

            }
        }
    }
}
