using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Napisać program wczytujący od użytkownika liczbę rzeczywistą x. Wczytuj tak długo wartość
            //zmiennej x, aż przyjmie ona wartość dodatnią. Wczytaną dodatnią wartość liczby x wypisz na
            //ekranie.Użyj pętli do -while.
            int i;

            do
            {
                Console.WriteLine("podaj liczbę:");
                i = Convert.ToInt32(Console.ReadLine());
                
            }
            while (i <= 0);
            Console.WriteLine("liczba {0} jest dodatnia",i); 
            Console.ReadKey(true);

        }
    }
}
