using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Napisać program wczytujący dwie liczby i wypisujący na ekranie ich sumę, różnicę, iloczyn iiloraz.

            double a, b;
            Console.WriteLine("podaj a:");
                a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("podaj b:");
                b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Suma liczb wynosi:{0}", a + b);
            Console.WriteLine("różnica liczb wynosi: {0}", a - b);
            Console.WriteLine("iloczyn wynosi: {0}", a*b);
            Console.WriteLine("iloraz wynosi: {0}", a / b);

            Console.ReadKey(true);    
                }
    }
}
