using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._114
{
    internal class Program
    {
        static int pierwsza(int n)
        {
            if (n % n == 0 && n % 1 == 0) return 1;
            else return 0;
        }


        static void Main(string[] args)
        {
            // Napisz funkcję o nazwie czy_kw, która stwierdza, czy zadana jako parametr liczba całkowita
            // jest kwadratem pewnej liczby całkowitej.Liczby będące kwadratami liczb całkowitych to 1, 4,
            // 9, 16, 25, itd.Wartością funkcji ma być jeden, jeśli liczba spełnia warunek lub zero w
            // przeciwnym przypadku.Napisz program testujący utworzoną funkcję czy_kw.


            Console.WriteLine("{0}", pierwsza(6));
            
            
            

            
            Console.ReadKey(true);

        }
    }
}
