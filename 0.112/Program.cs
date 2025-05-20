using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._112
{
    internal class Program
    {
        //Napisać funkcję o nazwie NWD zwracającą wartość największego wspólnego dzielnika dla jej 
        //dwóch argumentów będących liczbami naturalnymi.
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
        
        static void Main(string[] args)
        {
            Console.WriteLine("NWD(24, 36): " + NWD(24, 36));
            Console.ReadKey(true);
        }
    }
}
