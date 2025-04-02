using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Wczytaj dwie liczby naturalne dodatnie n i k. Narysuj z gwiazdek na ekranie prostokąt 
            //posiadający n wierszy i k kolumn. Użyj pętli while.

            int i, j, k, n;
            Console.WriteLine("podaj ilość rzędów:");
            n= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("podaj ilość kolumn:");
            k= Convert.ToInt32(Console.ReadLine());
            i = 1;
            while (i <= n)
            {
                j = 1;
                while (j <= k)
                {
                    Console.Write(" * ");
                    j++;
                }
                Console.WriteLine(" ");
                i++;
            }
            Console.ReadKey(true);
        }
    }
}
