using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._01
{
    struct osoba
    {
        public string imie, nazwisko;
        public int rok;

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            osoba o;
            Console.WriteLine("podaj imie: ");
            o.imie = Console.ReadLine();
            Console.WriteLine("podaj nazwisko: ");
            o.nazwisko = Console.ReadLine();
            Console.WriteLine("podaj rok urodzenia: ");
            o.rok = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Twoje imie to {o.imie}, nazwisko {o.nazwisko} i urodził_ś się w {o.rok} roku.");
            Console.ReadKey(true);
        }
    }
}
