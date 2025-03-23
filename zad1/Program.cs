using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Napisać program wypisujący na ekranie kolejne liczby całkowite od 11 do 33. Użyj pętli for
            for (int i=11;i<=33;i++)
            { Console.Write("{0}, ", i);
            }
            Console.ReadKey();
        }
    }
}
