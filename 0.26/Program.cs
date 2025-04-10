using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Napisz program obliczający sumę n początkowych liczb nieparzystych. Liczbę n należy pobrać od użytkownika.
            int n, wynik = 0;
            Console.WriteLine("Podaj n:");
            n = Convert.ToInt32(Console.ReadLine());

            int liczba = 0;
            for (int i = 0; i <= n; i++)
            {
                if (i % 2 != 0)
                {
                    liczba += 2;
                    wynik += liczba;
                }
                
            }
            Console.WriteLine("Suma n początkowych liczb nieparzystych wynosi: " + wynik);
            
        }
        }
}
