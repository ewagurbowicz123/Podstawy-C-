using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Oblicz sumę liczb od 1 do 100

            int n = 100, suma = 0; 
            
            for (int i = 1; i <= n; i++)
            {
                
                suma += i;
                
            }
            Console.WriteLine("{0}", suma);
        }
    }
}
