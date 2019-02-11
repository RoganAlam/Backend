using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dit is een programma dat alle schrikkeljaren vanaf 1900 laat zien.");
            Console.Write("Voer hier het jaar in wat u aan het zoeken bent: ");
            string zoekopdrachtinput = Console.ReadLine();
            int zoekopdracht = int.Parse(zoekopdrachtinput);

            for (int jaar = 1900; jaar <= zoekopdracht; jaar++)
            {
                if ((jaar % 4 == 0 && jaar % 100 != 0) || (jaar % 400 == 0))
                {
                    Console.WriteLine(jaar);
                }
            }
            Console.ReadLine();
        }
        /*if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
                {
                    Console.WriteLine(year +" is a Leap Year ");
                }*/
    }
}
