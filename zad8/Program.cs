using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Wczytaj z klawiatury rok_początkowy i rok_końcowy oraz wypisz na ekranie wszystkie lata 
            // przestępne od roku_początkowego do roku_końcowego włącznie.

            int r1, r2;
            Console.WriteLine("podaj rok początkowy:");
            r1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("podaj rok końcowy:");
            r2 = Convert.ToInt32(Console.ReadLine());

            for (int i = r1; i <= r2; i++)
            {
                if ((i % 4 == 0) & (i % 100 != 0) || (i % 400 == 0))
                {
                    Console.WriteLine("{0} ", i);
                }
            }
            Console.ReadKey(true);

        }
    }
}
