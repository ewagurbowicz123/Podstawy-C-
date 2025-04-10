using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int r;
            Console.WriteLine("Podaj rok:");
            r = Convert.ToInt32(Console.ReadLine());

            if (r % 4 == 0 && r % 100 != 0 || r % 400 == 0)
            {
                Console.WriteLine("Rok przestępny");
            }
            else
            {
                Console.WriteLine("Rok nieprzestępny");
            }
        }
    }
}
