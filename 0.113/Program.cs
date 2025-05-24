using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._113
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] tab = new int[1000];
            Console.Write("poodaj n");
            int i, n = Convert.ToInt32(Console.ReadLine());

            for (i = 0; i<n;i++)
            {
                Console.WriteLine("podaj tab[{0}]", i);
                tab[i] = Convert.ToInt32(Console.ReadLine());

            }
            int min, max;
            min = tab[0];
            max = tab[0];

            for (i = 0; i < n; i++) 
            {
                if (tab[i] < min)
                    min = tab[i];
            }

            for (i = 0; i < n; i++)
            {
                if (tab[i] > max)
                    max = tab[i];

            }


                Console.ReadKey(true);
        }
    }
}
