using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._02
{
    internal class Program
    {
        static long fib(long n)
        {
            if (n == 0) return 0;
            else if (n==1) return 1;
            else return fib(n - 1) + fib(n - 2);
        }
        static void Main(string[] args)
        {
            Console.Write("podaj n:");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n < 0) Console.Write("błąd");
            else Console.WriteLine("Fib({0})={1}", n, fib(n));
            Console.ReadKey(true);
        }
    }
}
