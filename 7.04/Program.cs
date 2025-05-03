using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._04
{
    internal class Program
    {
        static int ile_cyfr(int n)
        {
            int i = 1;
            while(n/10>10)
                {
                n /= 10;
                i++;

            }
            return i+1;
        }
        static void Main(string[] args)
        {
                Console.WriteLine("podaj liczbe:");
                int k = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"liczba cyfr w {k} to: " + ile_cyfr(k));
                Console.ReadKey();
            }
    }
}
