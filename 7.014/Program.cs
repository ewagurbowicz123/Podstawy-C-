using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._014
{
    internal class Program
    {
        //. Napisz funkcję, która stwierdza, czy zadana jako argument liczba całkowita kończy się swoim 
        //pierwiastkiem.Liczby kończące się swoim pierwiastkiem to np.: 25, 625. Wartością funkcji ma
        //być jeden, jeśli liczba spełnia warunek lub zero w przeciwnym przypadku.
        static int CzyKonczySiePierwiastkiem(int n)
        {
            for (int i = 1; i * i <= n; i++)
            {
                if (i * i == n) continue;
                if (n.ToString().EndsWith(i.ToString()) && i * i == n) return 1;
                if (n.ToString().EndsWith(i.ToString()) && i * i != n)
                {
                    int pierw = i;
                    if (pierw * pierw == n) continue;
                    if (n % (int)Math.Pow(10, pierw.ToString().Length) == pierw)
                        return 1;
                }
            }
            return 0;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Czy 625 kończy się swoim pierwiastkiem: " + CzyKonczySiePierwiastkiem(625));
        }
    }
}
