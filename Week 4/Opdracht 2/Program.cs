using System;

namespace Opdracht_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int matched = 0;

            Console.Write("Geef een richtgetal: ");
            int richt = int.Parse(Console.ReadLine());

            Console.Write("Geef een getal: ");
            int number = int.Parse(Console.ReadLine());

            while (number != 0)
            {
                if (number == richt) matched++;

                Console.Write("Geef een getal: ");
                number = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("\nHet aantal gelijken getalen is: {0}", matched);
        }
    }
}
