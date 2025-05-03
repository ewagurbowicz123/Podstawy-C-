using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._01
{
    internal class Program
    {
        static long silnia(int n)
        {
            if (n == 0)
                return 1;
            else
                return n * silnia(n - 1);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj liczbę do obliczenia silni:");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n < 0)
            {
                Console.WriteLine("bląd :)");
            }
            else
            {
                
                Console.WriteLine($"{n}!={silnia(n)}");
                Console.ReadKey();
            }
        }
    }
}
