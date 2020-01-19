using System;

namespace Opdracht_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] getallen = new int[20];
            int counter = 0;

            Console.Write("Geef een getal (0 = stoppen): ");
            int getal = int.Parse(Console.ReadLine());

            while (getal != 0)
            {
                if (counter < 20)
                {
                    getallen[counter] = getal;
                }

                Console.Write("Geef een getal (0 = stoppen): ");
                getal = int.Parse(Console.ReadLine());

                counter++;
            }

            Console.Write("\nGeef de zoek waarde: ");
            int zoek = int.Parse(Console.ReadLine());

            Console.WriteLine("\nDe zoekwaarde is: {0}", zoek);
            int gevonden = 0;

            for (int i = 0; i < 20; i ++)
            {
                if (getallen[i] == zoek)
                {
                    gevonden += 1;
                }
            }

            Console.WriteLine("\nDe zoekwaarde komt {0} keer voor", gevonden);
            Console.ReadKey();
        }
    }
}
