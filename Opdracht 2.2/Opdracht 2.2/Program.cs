using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your weight (kg): ");
            double kg = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter your height (m): ");
            double height = Convert.ToDouble(Console.ReadLine());

            double BMI = kg / (height * height);
            Console.WriteLine("Your BMI is: " + BMI);
            Console.ReadKey();

            if (BMI <= 16)
                Console.WriteLine("You're severely underweight");
            else
                if (BMI <= 18.5)
                    Console.WriteLine("You're underweight");
                else
                    if (BMI <= 25)
                        Console.WriteLine("You have a normal weight");
                    else
                        if (BMI <= 30)
                            Console.WriteLine("You're overweight");
                        else
                            if (BMI <= 35)
                                Console.WriteLine("You're moderately obese");
                            else
                                Console.WriteLine("You're severely obese");


            /*Less than 16.0 - Severely Underweight
            From 16.0 to 18.5 - Underweight
            From 18.6 to 25.0 - Normal Weight
            From 25.1 to 30.0 - Overweight
            From 30.1 to 35.0 - Moderately Obese
            More than 35.0 - Severely Obese
            */
        }
    }
}
