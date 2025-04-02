using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Napisz program wczytujący dwie liczby całkowite a oraz b (a<b) i obliczający sumę kolejnych 
            //liczb całkowitych począwszy od liczby a, a skończywszy na liczbie b. Obliczoną sumę wypisz
            //na ekranie.

            Console.BackgroundColor = ConsoleColor.Magenta;
            int a, b, i, suma = 0;
            Console.WriteLine("podaj a:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("podaj b:");
            b = Convert.ToInt32(Console.ReadLine());
            i = a;
            while (i <= b)
            { 
                suma += i;
                i++;
            }
            Console.WriteLine("{0}+..+{1}={2}", a, b, suma);
            Console.ReadKey(true);
        }
    }
}
