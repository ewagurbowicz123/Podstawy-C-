using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] dni = new string[] { "poniedziałek", "wtorek", "środa", "czwartek", "piątek", "sobota", "niedziela" };

            foreach (string elem    in dni)
            {
                Console.WriteLine(elem);
            }
            Console.ReadKey(true);
        }
    }
}
