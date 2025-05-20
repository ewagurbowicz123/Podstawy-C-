using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._111
{
    internal class Program
    {
        static double pole(double p, double q)
        {
            return (p * q) / 2;
        }

        static void Main(string[] args)
        {

            Console.WriteLine("pole deltoidu: {0}", pole(4, 5));

            Console.ReadKey(true);

        }
    }
}
