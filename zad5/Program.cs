using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Wczytaj liczbę naturalną n(n > 1).Narysuj na ekranie z gwiazdek trójkąt prostokątny. Użyj pętli for.

            int n,i,j;
            Console.WriteLine("podaj liczbę n:");
            n = Convert.ToInt32(Console.ReadLine());

            for (i = 1; i <= n; i++)
            {
                for (j = 1; j <= i; j++)
                    Console.Write("*");
                Console.WriteLine("");

            }
                
            Console.ReadKey(true);

        }
    }
}
