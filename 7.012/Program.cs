using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._012
{
    internal class Program
    {
        //Napisz funkcję, która posiada parametr będący liczbą naturalną zapisaną w systemie 
        //dziesiętnym, zamienia go na liczbę zapisaną w systemie ósemkowym i zwraca wyznaczoną
        //liczbę jako wartość funkcji.Napisz program testujący utworzoną funkcję.

        static string DziesietnaNaOsemkowa(int liczba)
        {
            string wynik = "";
            while (liczba > 0)
            {
                wynik = (liczba % 8).ToString() + wynik;
                liczba /= 8;
            }
            return wynik == "" ? "0" : wynik;
        }
            static void Main(string[] args)
        {
            Console.WriteLine("Zamiana 83 na system ósemkowy: " + DziesietnaNaOsemkowa(45));
        }
    }
}
