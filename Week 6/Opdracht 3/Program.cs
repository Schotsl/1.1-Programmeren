using System;

namespace Opdracht_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Geef een jaar: ");
            int year = int.Parse(Console.ReadLine());

            while (year > 0)
            {
                bool isSchrikkelJaar = IsSchrikkelJaar(year);

                if (isSchrikkelJaar)
                {
                    Console.Write($"Jaar {year} is een schrikkel jaar\n");
                }
                else
                {
                    Console.Write($"Jaar {year} is niet een schrikkel jaar\n");
                }

                Console.Write("\nGeef een jaar: ");
                year = int.Parse(Console.ReadLine());
            }

            Console.ReadKey();
        }

        static bool IsSchrikkelJaar(int jaar)
        {
            if (jaar % 400 == 0 || jaar % 100 != 0 && jaar % 4 == 0) {
                return true;
            }

            return false;
        }
    }
}
