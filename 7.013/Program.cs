using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._013
{
    internal class Program
    {
        // Napisz funkcję o nazwie czy_kw, która stwierdza, czy zadana jako parametr liczba całkowita 
        //jest kwadratem pewnej liczby całkowitej.Liczby będące kwadratami liczb całkowitych to 1, 4,
        //9, 16, 25, itd. Wartością funkcji ma być jeden, jeśli liczba spełnia warunek lub zero w
        //przeciwnym przypadku.Napisz program testujący utworzoną funkcję czy_kw.
        //Proszę nie korzystać z funkcji matematycznej Math.Sqrt(). 

        static int CzyKwadrat(int n)
        {
            for (int i = 0; i * i <= n; i++)
            {
                if (i * i == n) return 1;
            }
            return 0;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Czy 49 to kwadrat liczby całkowitej: " + CzyKwadrat(24));
        }
    }
}
