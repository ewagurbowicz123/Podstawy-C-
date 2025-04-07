using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._3
{
    class Program
    {
        static double pole_kola(double r)
        {
            return Math.PI * r * r;

        }
        static void Main(string[] args)
        {
            Console.WriteLine("pole koła dla r = 5 wynosi: {0} ", pole_kola(6));

        }


        //Napisz funkcję o nazwie pole_kola, która posiada jeden parametr r-promień koła i zwraca
        //obliczoną wartość pola koła.Napisz program wykorzystujący funkcję pole_kola
    }

}
