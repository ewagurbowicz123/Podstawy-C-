using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Wypisz wszystkie liczby od 1 do 100 podzielne przez 3 i 5.

            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine($"{i}");
                }
            }
            //japierdole ale łatwo 
        }
    }
}
