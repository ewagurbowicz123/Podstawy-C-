using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Wczytaj dwie liczby naturalne dodatnie n i k. Narysuj z gwiazdek na ekranie prostokąt 
            //posiadający n wierszy i k kolumn. Użyj pętli for. 

            int k, n,j,i;
            Console.WriteLine("podaj ilość kolumn:");
            n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("podaj długość wierszy:");
            k = Convert.ToInt32(Console.ReadLine());

            for (i = 1; i <= n; i++)
            {
                Console.WriteLine(" ");
                for (j = 1; j <= k; j++)
                    Console.Write("*");
            }
            Console.ReadKey(true);
        }
    }
}
