using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string imie;
            Console.WriteLine("Podaj swoje imie: ");
            imie = Console.ReadLine();
            Console.WriteLine("Czesc " + imie); 

            Console.ReadKey(true);  
        }
    }
}
