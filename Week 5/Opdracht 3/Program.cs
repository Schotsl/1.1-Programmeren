using System;

namespace Opdracht_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Geef het vaknaam: ");
            string vak = Console.ReadLine();

            Console.Write("Geef het aantal studenten: ");
            int aantal = int.Parse(Console.ReadLine());

            string[] namen = new string[aantal];
            float[] cijfers = new float[aantal];

            Console.WriteLine();

            for (int i = 0; i < aantal; i ++)
            {
                Console.Write("Geef de naam van de {0}e student: ", i + 1);
                namen[i] = Console.ReadLine();
            }

            Console.WriteLine();

            float hoogste = 0;
            float totaal = 0;

            for (int i = 0; i < aantal; i++)
            {
                Console.Write("Geef het cijfer van {0}: ", namen[i]);
                cijfers[i] = float.Parse(Console.ReadLine());

                totaal += cijfers[i];

                if (cijfers[i] > hoogste)
                {
                    hoogste = cijfers[i];
                }
            }

            float gemiddelde = totaal / aantal;

            Console.WriteLine("\nHet gemiddelde cijfer is: {0}", gemiddelde);
            Console.WriteLine("Het hoogste cijfer is: {0}", hoogste);
            Console.WriteLine();

            for (int i = 0; i < aantal; i ++)
            {
                Console.WriteLine("Student {0} heeft voor {1} het cijfer {2}", namen[i], vak, cijfers[i]);
            }

            Console.ReadKey();
        }
    }
}
