using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int r;
            Console.WriteLine("podaj r: ");
            r = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Pole koła o promieniu {r} wynosi {Math.PI * r * r}");
            Console.WriteLine($"Obwód koła o promieniu {r} wynosi {2 * Math.PI * r}");
        }
    }
}
