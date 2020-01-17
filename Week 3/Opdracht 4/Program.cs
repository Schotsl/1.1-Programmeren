using System;

namespace Opdracht_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[3];

            Console.Write("Enter first number: ");
            numbers[0] = int.Parse(Console.ReadLine());

            Console.Write("Enter second number: ");
            numbers[1] = int.Parse(Console.ReadLine());

            Console.Write("Enter third number: ");
            numbers[2] = int.Parse(Console.ReadLine());

            int sum = 0;
            int lowest = numbers[0];
            int highest = numbers[0];

            for (int i = 0; i < numbers.Length; i ++)
            {
                sum += numbers[i];

                if (numbers[i] > highest)
                {
                    highest = numbers[i];
                }

                if (numbers[i] < lowest)
                {
                    lowest = numbers[i];
                }
            }

            Console.WriteLine();
            Console.WriteLine($"Sum: {sum}");

            double average = sum / (double)3;
            Console.WriteLine($"Average: {average}");

            int product = numbers[0] * numbers[1] * numbers[2];
            Console.WriteLine($"Product: {product}");

            Console.WriteLine($"Higest: {highest}");
            Console.WriteLine($"Lowest: {lowest}");
            Console.ReadKey();
        }
    }
}
