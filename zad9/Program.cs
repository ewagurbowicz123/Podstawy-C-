using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //tabliczka mnożenia

            
            for (int i = 1; i<=10; i++)
            {
                for (int j = 1; j <= 10; j++)
                    Console.Write(" {0,1} ", i * j);
                Console.WriteLine("  ");

            }
            Console.ReadKey(true);
        }
    }
}
