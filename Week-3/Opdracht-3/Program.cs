using System;

namespace Opdracht_3
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

            if (numbers[0] > numbers[2] && numbers[1] > numbers[2])
            {
                Console.WriteLine("\nThe third number is the smallest of the three");
            }
            else
            {
                Console.WriteLine("\nThe third number is not the smallest of the three");
            }

            Console.ReadKey();
        }
    }
}
