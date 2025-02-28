using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Napisać program wczytujący liczbę całkowitą i wypisujący informację, czy wczytana liczba jest dodatnia, ujemna, czy też równa zero.

            int a;
            Console.WriteLine("podaj liczbe:");
            a = Convert.ToInt32(Console.ReadLine());

            if (a > 0)
            {
                Console.WriteLine("liczba jest dodatnia");
            }
            else if (a < 0)
            {
                Console.WriteLine("liczba jest ujemna");
            }


            else
            {
                Console.WriteLine("liczba jest równa zero");
            }
            Console.ReadKey(true);
        }
    }
}
