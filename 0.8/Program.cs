using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Narysuj prostokąt z gwiazdek o wymiarach podanych przez użytkownika.
            int k, l;

            Console.WriteLine("podaj długość a:");
            k= Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("podaj długość b:");
            l = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < k; i++)
            {
                for (int j = 0; j < l; j++)
                { Console.Write("*"); }

                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
