using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("Podaj liczbe: ");
            a = Convert.ToInt32(Console.ReadLine());

            if (a % 2 == 0)
            {
                Console.WriteLine($"{a} jest liczba parzysta");
            }
            else
            {
                Console.WriteLine($"{a} jest liczba nieparzysta");
            }
            Console.ReadKey(true);
        }
    }
}
