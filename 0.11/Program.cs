using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //trojkat prostokątny

            int n;
            Console.WriteLine("podaj dlugosc n:");
            n = Convert.ToInt32(Console.ReadLine());

            

            for (int i=1; i<=n; i++)
            {
                for (int j=1; j<=i;j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine(" ");
            }
            Console.WriteLine("");
        }
    }
}
