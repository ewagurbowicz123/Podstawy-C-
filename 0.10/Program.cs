using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj liczbę wierszy trójkąta Pascala:");
            if (int.TryParse(Console.ReadLine(), out int n))
            {
                GeneratePascalsTriangle(n);
            }
            else
            {
                Console.WriteLine("Nieprawidłowa liczba.");
            }
        }

        static void GeneratePascalsTriangle(int n)
        {
            for (int line = 0; line < n; line++)
            {
                int value = 1; // pierwsza wartość w wierszu jest zawsze 1
                for (int i = 0; i <= line; i++)
                {
                    Console.Write(value + " ");
                    value = value * (line - i) / (i + 1);
                }
                Console.WriteLine();
            }
        }
    }

}
        