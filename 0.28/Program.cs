using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._28
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Wczytaj liczbę naturalną n (n>4). Narysuj na ekranie ze znaków X kontur trójkąta prostokątnego jak na poniższym przykładzie.Użyj pętli for. 

            int n;
            Console.WriteLine("Podaj liczbę większą od 4");
            n = Convert.ToInt32(Console.ReadLine());
            if (n < 4)
            {
                Console.WriteLine("Liczba musi być większa od 4");
                return;
            }
            else
            {
                for (int i = 1; i <= n; i++)
                {
                    for (int j = 1; j <= n; j++)
                    {
                        if (i == n || j == 1 || i == j)
                            Console.Write("X");
                        else
                            Console.Write(" ");
                    }
                    Console.WriteLine();
                }
            }
            }
    }
}
