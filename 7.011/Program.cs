using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._011
{
    internal class Program
    {
        // Napisać funkcję o nazwie NWW zwracającą wartość najmniejszej wspólnej wielokrotności dla 
        //jej dwóch argumentów będących liczbami naturalnymi.
        static int NWD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }
        static int NWW(int a, int b)

        {
            return a * b / NWD(a, b);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("NWW(6, 8): " + NWW(6, 8));
        }
    }
}
