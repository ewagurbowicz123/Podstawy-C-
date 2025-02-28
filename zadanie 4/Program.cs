using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b, pole, obwod;
            Console.WriteLine("podaj liczbe a:");
            a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("podaj liczbe b");
            b = Convert.ToDouble(Console.ReadLine());

            pole = a * b;
            obwod = (2 * a) + (2 * b);
            Console.WriteLine("pole rowna się {0}", pole);
            Console.WriteLine("obwod równa sie {0}", obwod);    

            Console.ReadKey(true);
        }
    }
}
