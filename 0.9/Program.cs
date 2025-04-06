using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////Zamień liczbę dziesiętną na binarną(np. 13 → 1101).

            int b;
            Console.WriteLine("podaj liczbę:");
            b= Convert.ToInt32(Console.ReadLine());

            string binarna = Convert.ToString(b, 2);

            Console.WriteLine("Liczba binarna: " + binarna);

        }
    }
}
