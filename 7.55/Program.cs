using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _7._55
{
    internal class Program
    {
        static int czy_pierwsza(int liczba)
        {
            int i;
            for (i=2;i< liczba; i++)
            {
                if (liczba % i == 0)
                {
                    return 0;
                }
                return 1;
            }
            
        }
        static void Main(string[] args)
        {
            //Napisz funkcję, która sprawdza czy jej argument jest liczbą pierwszą. Jako wartość funkcja
            //powinna zwracać 1 dla liczb pierwszych i 0 dla pozostałych liczb.Przetestuj działanie
            //utworzonej funkcji

            
            Console.WriteLine("Liczba  jest pierwsza", czy_pierwsza(12));
            Console.ReadKey(true);

        }
    }
}
