using System;

namespace Opdracht_2._4
{
    class Program
    {
        static void Main(string[] args)
        {
            string name, input;
            DateTime dateOfBirth;
            Console.WriteLine("What is your name");
            name = Console.ReadLine();
            Console.WriteLine("What is your date of birth");
            dateOfBirth = Convert.ToDateTime( Console.ReadLine());
            TimeSpan age = DateTime.Now.Subtract(dateOfBirth);
            Console.WriteLine("Hello " + name + " you are " + age.Days/365 + " years old");
            Console.ReadLine();
        }
    }
}
