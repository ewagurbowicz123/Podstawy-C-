using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadani_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Napisać program wczytujący pięć liczb i wypisujący na ekranie wartość najmniejszej największej z tych liczb.

            double a, b, c, d, e, min, max;
            Console.WriteLine("podaj liczbę:");
            a= Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("podaj liczbę:");
            b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("podaj liczbę:");
            c = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("podaj liczbę:");
            d = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("podaj liczbę:");
            e = Convert.ToDouble(Console.ReadLine());

            min = a;
            if (b < min) min = b;
            if (c < min) min = c;   
            if (d < min) min = d;  
            if (e < min) min = e;
            Console.WriteLine("najmniejsza jest {0}", min);


            max = a;
            if (b > max) max= b;
            if (c > max) max = c;
            if (d > max) max= d;
            if (e > max) max = e;
            Console.WriteLine("największa jest {0}", max); 

            Console.ReadKey(true);
        }
    }
}
