using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  Napisz program drukujący na ekranie kolejne liczby naturalne podzielne przez 7. Ilość liczb 
            // wczytaj z klawiatury.Użyj pętli for.
            int ile, liczba;
            Console.WriteLine("podaj ilość liczb podzielnych przez 7:");
            ile = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < ile; i++)
            {
                liczba = i * 7;
                 
                Console.WriteLine("{0}",liczba );    
            }
            Console.ReadKey(true);
        }
    }
}
