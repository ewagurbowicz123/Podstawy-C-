using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Wypisz n pierwszych liczb ciągu Fibonacciego.
            int n;
            Console.WriteLine("podaj liczbe:");
            n = Convert.ToInt32(Console.ReadLine());

            int a=0,b=1;
            for (int i = 0; i < n; i++)
            {
                Console.Write(a + " ");
                int ciag = a + b;
                a = b;
                b=ciag;
            }
            
        }
    }
}
