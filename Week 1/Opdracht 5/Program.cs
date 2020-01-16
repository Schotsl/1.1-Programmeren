using System;

namespace Opdracht_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int totaal = 0;

            for (int i = 0; i < 4; i ++)
            {
                int number = random.Next(101, 10000);
                Console.WriteLine("Getal {0}: {1}", i + 1, number);
                totaal += number;
            }

            Console.WriteLine("\nTotaal: {0}", totaal);
            Console.ReadKey();
        }
    }
}
