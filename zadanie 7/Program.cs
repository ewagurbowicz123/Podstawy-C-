using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Napisać program wczytujący dwie liczby całkowite i wypisujący na ekranie iloraz tych liczb zuwzględnieniem części całkowitej i reszty z dzielenia.

            int  a, b;
            Console.WriteLine("podaj liczbę a:");
            a = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("podaj liczbe b:");
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("iloraz liczb {0}/{1} wynosi {2},{3}", a,b,a/b, a%b);
            Console.ReadKey(true);  
        }
    }
}
