using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Napisać program, który będzie umożliwiał użytkownikowi obliczenia pól figur płaskich. 
            //Jeżeli użytkownik wybierze 1, to powinien mieć możliwość obliczenia pola prostokąta,   
            //dla 2 – pola kwadratu, a dla 3 – pola trójkąta. Program powinien pytać użytkownika, które
            //pole chce obliczyć aż do momentu, kiedy użytkownik wpisze 0(zero).

            int wybór;
           
            do
            {
                Console.WriteLine(" ");   
                Console.WriteLine(" WYBIERZ CO CHCIAŁBYŚ ZROBIĆ:");
                Console.WriteLine();
                Console.WriteLine("1 - obliczenie pola prostokąta");
                Console.WriteLine("2 - obliczenie pola kwadratu");
                Console.WriteLine("3 - obliczenie pola trójkąta");
                Console.WriteLine("0 - koniec");
                Console.WriteLine();
                Console.Write("twój wybór: ");
                wybór = Convert.ToInt32(Console.ReadLine());

                switch (wybór)
                {
                    default:
                        Console.WriteLine("!!!!Hahaha -_- bardzo śmieszne wybierz coś innego!!!!"); break;
                    case 0: Console.WriteLine("Koniec"); break;

                    case 1:
                        int a, b;
                        Console.WriteLine("podaj długość a:");
                        a = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("podaj długość b:");
                        b = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("pole prostokąta równa się: {0}", a * b); break;

                    case 2:
                        int c;
                        Console.WriteLine("podaj długość boku a: ");
                        c = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Pole kwadratu wynosi: {0}", c * c); break;

                    case 3:
                        int d, h;
                        Console.WriteLine("podaj długość boku:");
                        d = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("podaj wysokość trójkąta:");
                        h = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Pole trójkąta wynosi: {0}", (d * h) / 2); break;
                    

                }

            }
            while (wybór !=0);
            Console.ReadKey(true);
        }
    }
}
