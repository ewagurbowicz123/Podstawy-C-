using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Napisać program wczytujący pięć liczb i wypisujący na ekranie wartość najmniejszej 
            //największej z tych liczb.

            int a, b, c, d, e;
            Console.WriteLine("Podaj a: ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Podaj b: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj c: ");
            c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj d: ");
            d = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj e: ");
            e = Convert.ToInt32(Console.ReadLine());

            Math.Max(a, Math.Max(b, Math.Max(c, Math.Max(d, e))));
            Math.Min(a, Math.Min(b, Math.Min(c, Math.Min(d, e))));

            Console.WriteLine("Największa liczba to: " + Math.Max(a, Math.Max(b, Math.Max(c, Math.Max(d, e)))));

            Console.WriteLine("Najmniejsza liczba to: " + Math.Min(a, Math.Min(b, Math.Min(c, Math.Min(d, e)))));
            Console.WriteLine("");
        }
    }
}
