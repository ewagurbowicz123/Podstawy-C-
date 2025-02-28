using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Napisać program wczytujący dwie liczby całkowite i wypisujący na ekranie sumę kwadratów wczytanych liczb.

            double a, b;
            Console.WriteLine("podaj a:");
            a= Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("podaj b:");
            b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("suma kwadratów a i b wynosi:{0}", a*a+b*b);
            Console.ReadKey(true);

        }
    }
}
