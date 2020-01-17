using System;

namespace Opdracht_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[2];

            Console.Write("Enter first number: ");
            numbers[0] = int.Parse(Console.ReadLine());

            Console.Write("Enter second number: ");
            numbers[1] = int.Parse(Console.ReadLine());
            Console.WriteLine();

            if (numbers[0] % numbers[1] == 0)
            {
                Console.WriteLine("Number 1 is multiple of number 2");
            }
            else if (numbers[1] % numbers[0] == 0)
            {
                Console.WriteLine("Number 2 is multiple of number 1");
            }
            else
            {
                Console.WriteLine("Numbers are no multiples");
            }

            Console.ReadKey();
        }
    }
}
