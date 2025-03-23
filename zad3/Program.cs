using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Napisać program wczytujący liczbę całkowitą n(n> 2) i wypisujący na ekranie wartość sumy
            //1 + 2 +…+n.Do obliczenia wartości sumy użyj pętli for.

            int n, i, suma =0;
            Console.WriteLine("podaj liczbę całkowitą: ");
            n = Convert.ToInt32(Console.ReadLine());

            for (i = 1; i <= n; i++)
            
                suma += i;

            Console.WriteLine("suma = {0}", suma);
            
            Console.ReadKey(true);
        }
    }
}
