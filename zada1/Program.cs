using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zada1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Napisać program wczytujący współrzędne punktu P=(x,y) i wypisujący na ekranie informację, 
            //do której ćwiartki ten punkt należy, czy też informację, że leży on na osi OX i/ lub osi OY. 

            int x, y;
            Console.WriteLine("podaj x:");
            x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("podaj y");
            y = Convert.ToInt32(Console.ReadLine());

            if (x > 0 && y > 0) { Console.WriteLine("Punkt należy do I ćwiartki."); }
            else if (x < 0 && y > 0) { Console.WriteLine("Punkt należy do II ćwiartki."); }
            else if (x < 0 && y < 0) { Console.WriteLine("Punkt należy do  ćwiartki."); }
            else Console.WriteLine("Punkt należy do IV ćwiartki.");

            if (y == 0 && x == 0) { Console.WriteLine("punkt leży w centrum"); }
            else if (x == 0) { Console.WriteLine("dodatkowo punkt leży na osi 0Y "); }
            else if  (y == 0) { Console.WriteLine("dodatkowo punkt leży na osi 0X"); } 

                Console.ReadKey(true);

        }
    }
}
