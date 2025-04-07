using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._2
{
    class Program
    {
        static double max (double x,double y)
        {
            if (x > y) return x;
            else return y;
        }
        static void Main(string[] args)
        {

            Console.WriteLine("3 i 9, większa jest {0}", max(3, 9));
            Console.WriteLine("4 i 1, większa jest {0}", max(4, 1));
            Console.WriteLine("6 i 5, większa jest {0}", max(6, 5));
        }



        //Napisz funkcję o nazwie max, która wyznacza maksimum z dwóch liczb rzeczywistych
        //zadanych jako argumenty tej funkcji.Napisz program wykorzystujący funkcję max.

    }
}
