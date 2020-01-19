using System;

namespace Opdracht_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[2];

            Console.Write("Vul het eerste getal in: ");
            numbers[0] = int.Parse(Console.ReadLine());

            Console.Write("Vul het tweede getal in: ");
            numbers[1] = int.Parse(Console.ReadLine());
            Console.WriteLine();

            if (numbers[0] > numbers[1])
            {
                Console.WriteLine($"Grootste waarde is: {numbers[0]}");
                Console.WriteLine($"Kleinste waarde is: {numbers[1]}");
            }
            else
            {
                Console.WriteLine($"Grootste waarde is: {numbers[1]}");
                Console.WriteLine($"Kleinste waarde is: {numbers[0]}");
            }

            Console.ReadKey();
        }
    }
}
