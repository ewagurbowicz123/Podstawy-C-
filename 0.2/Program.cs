using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Wypisz liczby od 10 do 1 w kolejności malejącej.

            for (int i = 10; i >= 1; i--)
            {
                Console.Write("{0}, ",i);
            }
            Console.ReadKey(true);
        }
    }
}
