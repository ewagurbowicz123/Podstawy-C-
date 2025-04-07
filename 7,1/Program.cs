using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_1
{
    class Program
    {
        
        
            //Ulong to jakies liczby ale tylko dodatnie,

            //Napisz funkcję o nazwie suma wyznaczającą sumę jej dwóch argumentów będących liczbami
            //całkowitymi.Napisz program wykorzystujący funkcję suma

            static int suma(int a, int b)
            {
                return a + b;
            }

            static void Main(string[]args)
            {
            Console.Write("2+5={0}", suma(2, 5));
            Console.ReadKey(true);

            }
        
    }
}
