using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Zsumuj cyfry podanej liczby całkowitej(np. 123 → 1 + 2 + 3 = 6).
            Console.Write("Podaj liczbę całkowitą: ");
            int liczba = int.Parse(Console.ReadLine());

            int suma = 0;
            int n = Math.Abs(liczba); // obsługa liczb ujemnych

            while (n > 0)
            {
                suma += n % 10;
                n /= 10;
            }

            Console.WriteLine("Suma cyfr liczby " + liczba + " wynosi: " + suma);

            //tu nawet nie ma for xdd
        }
    }
}
