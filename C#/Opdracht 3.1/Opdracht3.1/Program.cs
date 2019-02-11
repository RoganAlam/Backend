using System;

namespace Opdracht3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write(" Wat is je naam?:  ");
            string name = Console.ReadLine();
            Console.Write(" Tussenvoegsels?:  ");
            string tussenvoegsels = Console.ReadLine();
            Console.Write(" Wat is je achternaam?:  ");
            string achternaam = Console.ReadLine();
            Console.WriteLine("Jouw naam is: " + name + " " + tussenvoegsels + " " + achternaam);
            Console.WriteLine(name.Length + tussenvoegsels.Length + achternaam.Length);
            Console.ReadKey();
        }
    }
}
