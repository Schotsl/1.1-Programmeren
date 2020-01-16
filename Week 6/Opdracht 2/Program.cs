using System;

namespace Opdracht_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Geef een getal: ");
            int number = int.Parse(Console.ReadLine());

            while (number > 0)
            {
                bool isPriemGetal = IsPriemGetal(number);

                if (isPriemGetal)
                {
                    Console.Write($"Getal {number} is een priemgetal\n");
                }
                else
                {
                    Console.Write($"Getal {number} is niet een priemgetal\n");
                }

                Console.Write("\nGeef een getal: ");
                number = int.Parse(Console.ReadLine());
            }

            Console.ReadKey();
        }

        static bool IsPriemGetal(int getal)
        {
            if (getal == 1) return false;
            if (getal == 2) return true;

            for (int i = 2; i < getal; i++)
            {
                if ((getal % i) == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
