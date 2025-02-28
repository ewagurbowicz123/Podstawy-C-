using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Napisać program wczytujący trzy liczby i wypisujący na ekranie wartość najmniejszej i największej z tych liczb.

            double a, b, c;
            Console.WriteLine("podaj liczbę a");
                a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("podaj liczbę b:");
             b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("podaj liczbę c");
            c = Convert.ToDouble(Console.ReadLine());

           

            if ((a < b) && (a< c))
             Console.WriteLine("najmniejsza liczba to {0}", a); 
           
            else if ((b < c) && (b<a))
                    Console.WriteLine("najmniejsza liczba to {0}",b);

            else
                    Console.WriteLine("najmniejsza liczba to {0}", c);

            if ((a > b) && (a> c))  
                Console.WriteLine("największa liczba to {0}",a);
            else if ((b>c)&& (b>c))
                Console.WriteLine("największa liczba to {0}",b) ;
            else 
                Console.WriteLine("największa liczba to {0}",c);

            Console.ReadKey(true);  

            

            
        }
    }
}
