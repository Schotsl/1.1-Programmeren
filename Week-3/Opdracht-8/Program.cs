using System;

namespace Opdracht_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number of working hours: ");
            int hours = int.Parse(Console.ReadLine());

            Console.Write("Enter number of years: ");
            int years = int.Parse(Console.ReadLine());

            Console.Write("Enter number of failures: ");
            int failures = int.Parse(Console.ReadLine());

            if (hours > 10000 || years >= 7 || failures > 25)
            {
                Console.WriteLine("\nMachine needs to be replaced");
            }
            else
            {
                Console.WriteLine("\nMachine does not need to repaced");
            }

            Console.ReadKey();
        }
    }
}
