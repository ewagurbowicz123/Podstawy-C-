using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Napisać program wczytujący liczbę całkowitą i wypisujący na ekranie informację czy jest to liczba parzysta, czy też nieparzysta

            int a;
            Console.WriteLine("podaj a:");
            a = Convert.ToInt32(Console.ReadLine());

            if (a % 2 == 0)
            {
                Console.WriteLine("liczba {0} jest parzysta", a);
            }

            else
            {
                Console.WriteLine("liczba nie jest parzysta");
            }

                Console.ReadKey(true);
          
        }
    }
}
