using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zada2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Napisać program wczytujący współrzędne dwóch punktów A=(x1,y1) i B=(x2,y2) oraz wypisujący na ekranie wzór funkcji liniowej przechodzącej przez te dwa punkty.

            double x1, x2, y1, y2;
            Console.WriteLine("podaj wartość x1:");
            x1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("podaj wartość y1:");
            y1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("podaj wartość x2:");
            x2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("podaj wartość y2:");
            y2 = Convert.ToDouble(Console.ReadLine());


            double a = (y2 - y1) / (x2 - x1);
            double b = y1 - a * x1;

            if (x1 == x2) {Console.WriteLine("Funkcja liniowa nie istnieje – prosta jest pionowa: x = " + x1); }
            else if (a == 0 && a == 1) { Console.WriteLine($"Wzór funkcji liniowej: y = x + {b}"); }
            else  Console.WriteLine($"Wzór funkcji liniowej: y = {a}x + {b}");
            
            Console.WriteLine("");
            
        }
    }
}
