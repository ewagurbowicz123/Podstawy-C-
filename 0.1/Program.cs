using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            
            //Znajdź najmniejszą wspólną wielokrotność(NWW) dwóch liczb.
            //Znajdź największy wspólny dzielnik(NWD) dwóch liczb.
            //Generuj trójkąt Pascala dla n wierszy.
            //Zgadnij liczbę: komputer losuje liczbę od 1 do 100, użytkownik zgaduje, a program mówi "za dużo", "za mało" lub "trafione".


            //napisz program który przy użyciu pętli for wypisze tablicę mnożenia dla podanej przez użytkownika (np. dla liczby 3: 3*1=3,3*2=6,3*3=9...
            int n;
            Console.WriteLine("podaj liczbę:");
            n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{i}*{n}={i * n}");
            }
            Console.ReadKey(true);
        }
    }
}
