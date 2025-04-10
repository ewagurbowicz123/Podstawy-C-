using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._31
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a,b;
            Console.WriteLine("podaj wartość a:");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("podaj wartość b:");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");
            while (a <= b)
            {
                if (a % 2 == 0)
                    Console.Write("{0}, ", a);
                a++;
            }
            Console.WriteLine("");
        }
    }
}
