using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Wczytaj z klawiatury dwie liczby naturalne a i b (0<a<b). Wyznacz wszystkie liczby parzyste z 
            //przedziału [a, b].Użyj pętli while.

            int a, b,i;
            Console.WriteLine("podaj dwie liczby naturalne");
            Console.Write("a: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("podaj b: ");
            b = Convert.ToInt32(Console.ReadLine());
            i = a;
            
            while (i <= b)
            {
                if (i % 2 == 0)

                    Console.WriteLine("{0}", i);
                i++;
            }
            
            
            
            

            Console.ReadKey(true);
        }
    }
}
