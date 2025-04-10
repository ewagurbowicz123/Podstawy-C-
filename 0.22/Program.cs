using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int m;
            Console.Write("podaj numer:");
            m = Convert.ToInt32(Console.ReadLine());

            switch (m)
            {
                case 1: Console.WriteLine("Styczeń"); break;
                case 2: Console.WriteLine("Luty"); break;
                case 3: Console.WriteLine("Marzec"); break;
                case 4: Console.WriteLine("Kwiecień"); break;
                case 5: Console.WriteLine("Maj"); break;
                case 6: Console.WriteLine("Czerwiec"); break;
                case 7: Console.WriteLine("Lipiec"); break;
                case 8: Console.WriteLine("Sierpień"); break;
                case 9: Console.WriteLine("Wrzesień"); break;
                case 10: Console.WriteLine("Październik"); break;
                case 11: Console.WriteLine("Listopad"); break;
                case 12: Console.WriteLine("Grudzień"); break;
                default: Console.WriteLine("Nie ma takiego miesiąca"); break;
            }
        }
    }
}
