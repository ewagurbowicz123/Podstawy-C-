using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Napisać program wczytujący rok i wypisujący na ekranie informację czy jest to rok przestęp czy też nie

            int rok;
            Console.WriteLine("podaj rok");
            rok = Convert.ToInt32(Console.ReadLine());

            if  (((rok % 4 == 0) && (rok % 100 !=0)) || (rok % 400 == 0))
                    Console.WriteLine("rok jest przestępny"); 

            else { Console.WriteLine("rok nie jest przestępny"); }

            Console.ReadKey(true);

        }
    }
}
