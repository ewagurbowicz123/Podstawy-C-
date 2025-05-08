using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._02
{
    internal class Program
    {
        struct uczen
        {
            public string imie;
            public string nazwisko;
            public int[] oceny;
        }
     
        
            static void Main(string[] args)
        {
            //Zdefiniuj strukturę o nazwie Uczen zawierającą pola: imie, nazwisko i tablice ocen.
            //Pobierz od użytkownika liczbę uczniów i zadeklaruj odpowiednią tablicę struktur
            //umożliwiającą przechowanie informacji o imionach, nazwiskach i ocenach uczniów.
            //Następnie pobierz dane od użytkownika i w sposób czytelny wypisz wszystko na ekranie.

            uczen[] uczniowie;
            int liczba_uczniow, ile_ocen, i, j;
            Console.WriteLine("Podaj liczbe uczniow: ");
            liczba_uczniow = Convert.ToInt32(Console.ReadLine());
            uczniowie = new uczen[liczba_uczniow];
            for (i = 0; i < liczba_uczniow; i++)
            {
                Console.WriteLine("Podaj imie ucznia {0}: ", i + 1);
                uczniowie[i].imie = Console.ReadLine();
                Console.WriteLine("Podaj nazwisko ucznia{0}: ", i + 1);
                uczniowie[i].nazwisko = Console.ReadLine();
                Console.WriteLine("ile ocen ma {0} {1}: ", uczniowie[i].imie, uczniowie[i].nazwisko);
                ile_ocen = Convert.ToInt32(Console.ReadLine());
                uczniowie[i].oceny = new int[ile_ocen];
                for (j = 0; j < ile_ocen; j++)
                {
                    Console.WriteLine("Podaj ocene numer {0}", j + 1);
                    uczniowie[i].oceny[j] = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine("");
            }

            for (i = 0; i < liczba_uczniow; i++)
            {
                Console.Write("{0}. {1} {2}", i + 1, uczniowie[i].imie, uczniowie[i].nazwisko);
                foreach (int ocena in uczniowie[i].oceny)
                {
                    Console.Write(" {0}", ocena);
                }
                Console.WriteLine();

            }
            Console.ReadKey();

        
        } 
    }
}
