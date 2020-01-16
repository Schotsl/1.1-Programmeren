using System;

namespace Opdracht_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int total = 0;
            int count = 0;

            Console.Write("Geef een getal: ");
            int number = int.Parse(Console.ReadLine());

            while (number != 0)
            {
                if (number % 5 == 0)
                {
                    total += number;
                    count += 1;
                }

                Console.Write("Geef een getal: ");
                number = int.Parse(Console.ReadLine());
            }

            float average = (float)total / (float)count;

            Console.WriteLine("\nHet gemiddelde is: {0}", average);
        }
    }
}
