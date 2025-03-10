using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_6
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //. Napisać program wczytujący numer miesiąca (od 1 do 12) i wypisujący na ekranie nazwę tegemiesiąca.Użyj instrukcji wyboru switch.


            Console.WriteLine("podaj nume)");
            int miesiac;
            miesiac = Convert.ToInt32(Console.ReadLine());
            switch (miesiac)
            {
                case 1: Console.WriteLine("styczeń"); break;
                case 2: Console.WriteLine("luty"); break;
                case 3: Console.WriteLine("marzec"); break;
                case 4: Console.WriteLine("kwiecień"); break;
                case 5: Console.WriteLine("maj"); break;
                case 6: Console.WriteLine("czerwiec"); break;
                case 7: Console.WriteLine("lipiec"); break;
                case 8: Console.WriteLine("sierpień"); break;
                case 9: Console.WriteLine("wrzesień"); break;
                case 10: Console.WriteLine("październik"); break;
                case 11: Console.WriteLine("listopad"); break;
                case 12: Console.WriteLine("grudzień"); break;
                default: Console.WriteLine("nie ma takiego miesiąca"); break;
            }
                    Console.ReadKey(true);

            
        }
    }
}
