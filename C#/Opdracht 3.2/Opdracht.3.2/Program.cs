using System;

namespace Opdracht._3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Voer de datum in dd-mm-yyyy");
            Console.Write("Wat is uw geboortedatum meneer?:  ");
            string man = Console.ReadLine();
            Console.Write("Wat is uw geboortedatum mevrouw?:  ");
            string vrouw = Console.ReadLine();
            DateTime start = DateTime.Parse(man);
            DateTime end = DateTime.Parse(vrouw);

            if (start < end)
            {
                TimeSpan difference = end - start;
                Console.WriteLine("Het verschil in dagen is: " + difference.Days);
                Console.ReadKey();
            }
            if (start > end)
            {
                TimeSpan difference = start - end;
                Console.WriteLine("Het verschil in dagen is: " + difference.Days);
                Console.ReadKey();
            }
        }
    }
}
