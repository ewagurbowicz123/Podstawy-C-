using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _7._4
{
    internal class Program
    {
        static int ile_cyfr(int liczba)
        {
            int i = 0;
            while (liczba /10> 0)
            {
                liczba /= 10;
                i++;

            }
            return i+1;
        }
        static void Main(string[] args)
        {
            //Napisz funkcję o nazwie ile_cyfr, która wyznacza liczbę cyfr dla zadanej liczby naturalnej jako argument tej funkcji. Napisz program wykorzystujący funkcję ile_cyfr
            Console.WriteLine("liczba 0 ma {0} cyfr", ile_cyfr(0));
            Console.WriteLine("Liczba 1234 ma {0} cyfr", ile_cyfr(1234));
            Console.ReadKey(true);


        }
    }
}
