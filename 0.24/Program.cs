using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Napisać program wczytujący liczbę arabską od 1 do 1 000 000 i wypisujący na ekranie słownie wczytaną liczbę. 
            int l;
            Console.WriteLine("Podaj liczbę od 1 do 1 000 000");
            l = Convert.ToInt32(Console.ReadLine());
            if (l < 1 || l > 1000000)
            {
                Console.WriteLine("Liczba poza zakresem");
                return;
            }

            Console.WriteLine(LiczbaSlownie(l));
        }

        static string LiczbaSlownie(int liczba)
        {
            if (liczba == 1000000)
                return "jeden milion";

            var jednostki = new[] { "", "jeden", "dwa", "trzy", "cztery", "pięć", "sześć", "siedem", "osiem", "dziewięć" };
            var nastki = new[] { "dziesięć", "jedenaście", "dwanaście", "trzynaście", "czternaście", "piętnaście", "szesnaście", "siedemnaście", "osiemnaście", "dziewiętnaście" };
            var dziesiatki = new[] { "", "", "dwadzieścia", "trzydzieści", "czterdzieści", "pięćdziesiąt", "sześćdziesiąt", "siedemdziesiąt", "osiemdziesiąt", "dziewięćdziesiąt" };
            var setki = new[] { "", "sto", "dwieście", "trzysta", "czterysta", "pięćset", "sześćset", "siedemset", "osiemset", "dziewięćset" };
            var tysiace = new[] { "", "tysiąc", "tysiące", "tysięcy" };

            string wynik = "";

            int tys = liczba / 1000;
            int reszta = liczba % 1000;

            if (tys > 0)
            {
                if (tys == 1)
                {
                    wynik += "tysiąc ";
                }
                else if (tys < 5)
                {
                    wynik += LiczbaSlownie(tys) + " " + tysiace[2] + " ";
                }
                else
                {
                    wynik += LiczbaSlownie(tys) + " " + tysiace[3] + " ";
                }
            }

            int set = reszta / 100;
            reszta %= 100;

            if (set > 0)
            {
                wynik += setki[set] + " ";
            }

            if (reszta >= 10 && reszta < 20)
            {
                wynik += nastki[reszta - 10] + " ";
            }
            else
            {
                int dzies = reszta / 10;
                reszta %= 10;

                if (dzies > 0)
                {
                    wynik += dziesiatki[dzies] + " ";
                }

                if (reszta > 0)
                {
                    wynik += jednostki[reszta] + " ";
                }
            }

            return wynik.Trim();
        }
    }
}
