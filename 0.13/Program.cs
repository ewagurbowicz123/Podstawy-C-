using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("Podaj liczbe calkowita: ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"{a*a*a}");
            Console.WriteLine();
        }
    }
}
