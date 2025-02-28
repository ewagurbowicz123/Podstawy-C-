using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Dany jest ciąg arytmetyczny a(n)=3n-1. Napisać program wczytujący numer wyrazu ciągu (n) i wypisujący na ekranie jego wartość

            double n;
            Console.WriteLine("podaj wartość n:");
            n = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("wartość ciągu n={0} równy jest {1}",n, 3 * n - 1);
            Console.ReadKey(true);  
        }
    }
}
