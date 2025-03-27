using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Napisz program obliczający sumę n początkowych liczb nieparzystych. Liczbę n należy pobrać 
            //od użytkownika. Przykładowo dla n = 3 należy obliczyć sumę 1 + 3 + 5. Do obliczenia wartości sumy użyj pętli for. 

            int n, suma=0, liczba;
            Console.WriteLine("podaj liczbe n");
            n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i < n; i++)
            {
                liczba = i + 2;
                suma += liczba;
                Console.WriteLine("{0},",suma );
            }
            Console.ReadKey(true);  
            // prawie działa
        }
    }
}
