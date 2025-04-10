using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("podaj liczbę:");
            double a;
            a = Convert.ToDouble(Console.ReadLine());

            if (a == 0)
                Console.WriteLine($"liczba {a} jest zerem");
            if (a<0)
                
                Console.WriteLine($"Liczba {a} jest ujemna");
                
            if (a>0)
                Console.WriteLine($"liczba {a} jest dodatnia");
            
            
        }
    }
}
