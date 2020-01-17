using System;

namespace Opdracht_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter weight (KG): ");
            int weight = int.Parse(Console.ReadLine());

            Console.Write("Enter length (CM): ");
            int length = int.Parse(Console.ReadLine());

            Console.Write("Enter gender (male/female): ");
            string gender = Console.ReadLine();
 
            double bmi = weight / Math.Pow((length / (double)100), 2);

            Console.WriteLine();
            Console.WriteLine($"BMI-values: {bmi}");

            int minBmi = 0;
            int maxBmi = 0;

            if (gender == "male")
            {
                minBmi = 20;
                maxBmi = 25;
            }
            else
            {
                minBmi = 19;
                maxBmi = 24;
            }

            Console.WriteLine($"Normal BMI-values (min..max): {minBmi}..{maxBmi}");

            double minWeight = minBmi * Math.Pow((length / (double)100), 2);
            double maxWeight = maxBmi * Math.Pow((length / (double)100), 2);

            Console.WriteLine($"Normal weight-values (min..max): {minWeight}..{maxWeight}");
            Console.ReadKey();
        }
    }
}
