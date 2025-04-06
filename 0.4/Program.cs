using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Oblicz iloczyn liczb od 1 do 10 (silnia z 10).

            int silnia=1, n;
            Console.WriteLine("Podaj liczbę:");
            n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                silnia *= i;

            }
            Console.WriteLine("silnia z {0} równa się {1}", n, silnia);
        }
    }
}
