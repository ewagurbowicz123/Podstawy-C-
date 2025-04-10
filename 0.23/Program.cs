using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("podaj liczbę od 1 do 3999");
            int n = Convert.ToInt32(Console.ReadLine());

            if (n < 1 || n > 3999)
            {
                Console.WriteLine("Liczba poza zakresem");
                return;
            }
            string[] jednostki = { "", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" };
            string[] dziesiatki = { "", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" };
            string[] setki = { "", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM" };
            string[] tysiące = { "", "M", "MM", "MMM" };
            string wynik = "";
            wynik += tysiące[n / 1000];
            n %= 1000;
            wynik += setki[n / 100];
            n %= 100;
            wynik += dziesiatki[n / 10];
            n %= 10;
            wynik += jednostki[n];
            Console.WriteLine(wynik);

        }
    }
}
