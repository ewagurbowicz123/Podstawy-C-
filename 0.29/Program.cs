using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _0._29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Napisz program znajdujący wszystkie trójki liczb pitagorejskich z zadanego przedziału. Np.: dla przedziału[3, 5] mamy jedną trójkę: 3, 4, 5(bo 3 ^ 2 + 4 ^ 2 = 5 ^ 2).
            
            {
                // Pobierz przedział od użytkownika
                Console.WriteLine("Podaj dolną granicę przedziału:");
                if (!int.TryParse(Console.ReadLine(), out int dolnaGranica) || dolnaGranica < 1)
                {
                    Console.WriteLine("Podano nieprawidłową dolną granicę.");
                    return;
                }

                Console.WriteLine("Podaj górną granicę przedziału:");
                if (!int.TryParse(Console.ReadLine(), out int gornaGranica) || gornaGranica <= dolnaGranica)
                {
                    Console.WriteLine("Podano nieprawidłową górną granicę.");
                    return;
                }

                Console.WriteLine($"Trójki pitagorejskie w przedziale [{dolnaGranica}, {gornaGranica}]:");
                bool znaleziono = false;

                // Znajdź wszystkie trójki pitagorejskie
                for (int a = dolnaGranica; a <= gornaGranica; a++)
                {
                    for (int b = a; b <= gornaGranica; b++)
                    {
                        for (int c = b; c <= gornaGranica; c++)
                        {
                            if (a * a + b * b == c * c)
                            {
                                Console.WriteLine($"({a}, {b}, {c})");
                                znaleziono = true;
                            }
                        }
                    }
                }

                if (!znaleziono)
                {
                    Console.WriteLine("Nie znaleziono żadnych trójek pitagorejskich w podanym przedziale.");
                }
            }
        }
    }



}
    

