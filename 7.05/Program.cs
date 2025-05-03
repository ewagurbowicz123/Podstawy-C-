using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._05
{
    internal class Program
    {
        static int p(int l)
        {
            int i;
            for (i=2;i<l/2;i++)
                if (l % i == 0)
                    return 0;
            return 1;

        }
        static void Main(string[] args)
        {
            Console.WriteLine("{0}",p(13));
            Console.ReadKey();
        }
    }
}
