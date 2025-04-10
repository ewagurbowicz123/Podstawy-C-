using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Napisz program drukujący na ekranie kolejne liczby naturalne podzielne przez 7. Ilość liczb wczytaj z klawiatury.
            int n;
            Console.WriteLine("Podaj liczbę");
            n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i <= n; i++)
                if (i % 7 == 0)
                    Console.WriteLine(i);
            

            Console.WriteLine("");


        }
    }
}
