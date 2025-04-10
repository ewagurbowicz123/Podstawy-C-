using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._32
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n,i=1;
            Console.WriteLine("podaj n:");
            n = Convert.ToInt32(Console.ReadLine());

            while (i <= n)
            {
                Console.WriteLine($"a({2*i-1})");
                i++;
            }
            Console.WriteLine("");
        }
    }
}
