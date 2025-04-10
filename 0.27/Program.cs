using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Napisz program drukujący na ekranie liczby. Wysokość wczytaj z klawiatury. Użyj pętli for. 
            int n;
            Console.WriteLine("Podaj wysokość:");
            n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write( j * i +" " );
                }
                Console.WriteLine(" ");
            }

        }
    }
}
