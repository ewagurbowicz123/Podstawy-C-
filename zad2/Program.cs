using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Napisać program wczytujący ciąg n (1<=n<=1000) liczb całkowitych i wypisujący wczytane
            // liczby w odwrotnej kolejności na ekranie

            int[] tab = new int[1000];
            int i, n;
            Console.WriteLine("podaj ilość elementów tablicy n<=1000");
            n = Convert.ToInt32(Console.ReadLine());

            for (i = 0; i < n; i++)
            {
                Console.Write("Podaj tab:[{0}]", i);
                tab[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("elementy tablicy");

            for (i = n-1; i >= 0; i--)
            {
                Console.Write("{0}", tab[i]);
            }
            Console.ReadKey(true);
        }
    }
}
