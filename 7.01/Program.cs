using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._01
{
    internal class Program
    {
        static int suma(int a, int b)
        {
            return a + b;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("podaj a:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("podaj b:");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("suma a i b to: " + suma(a, b));
            Console.ReadKey();    
        }
    }
}
