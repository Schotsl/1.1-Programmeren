using System;

namespace Opdracht_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] kleutersArray = new int[10];
            int[] kinderenArray = new int[10];
            int[] volwassenenArray = new int[10];

            int kleutersIndex = 0;
            int kinderenIndex = 0;
            int volwassenenIndex = 0;

            Console.Write("Geef een leeftijd (0 = stoppen): ");
            int leeftijd = int.Parse(Console.ReadLine());

            while (leeftijd != 0)
            {
                if (leeftijd >= 1 && leeftijd <= 4)
                {
                    kleutersArray[kleutersIndex] = leeftijd;
                    kleutersIndex++;
                }
                else if (leeftijd >= 5 && leeftijd <= 17)
                {
                    kinderenArray[kinderenIndex] = leeftijd;
                    kinderenIndex++;
                }
                else
                {
                    volwassenenArray[volwassenenIndex] = leeftijd;
                    volwassenenIndex++;
                }

                Console.Write("Geef een leeftijd (0 = stoppen): ");
                leeftijd = int.Parse(Console.ReadLine());
            }

            int kleutersTotaal = 0;
            int kleutersHoogste = 0;

            Console.WriteLine("\n\nKLEUTERS");
            for (int i = 0; i < kleutersIndex; i ++)
            {
                Console.WriteLine("Kleuter {0} is {1} jaar.", i + 1, kleutersArray[i]);

                kleutersTotaal += kleutersArray[i];
                if (kleutersArray[i] > kleutersHoogste)
                {
                    kleutersHoogste = kleutersArray[i];
                }
            }

            float kleutersGemiddelde = (float)kleutersTotaal / (float)kleutersIndex;
            Console.WriteLine("De gemiddelde kleuters is: {0}", kleutersGemiddelde);
            Console.WriteLine("De oudste kleuters is: {0}", kleutersHoogste);

            int kinderenTotaal = 0;
            int kinderenHoogste = 0;

            Console.WriteLine("\n\nKINDEREN");
            for (int i = 0; i < kinderenIndex; i++)
            {
                Console.WriteLine("Kind {0} is {1} jaar.", i + 1, kinderenArray[i]);

                kinderenTotaal += kinderenArray[i];
                if (kinderenArray[i] > kinderenHoogste)
                {
                    kinderenHoogste = kinderenArray[i];
                }
            }

            float kinderenGemiddelde = (float)kinderenTotaal / (float)kinderenIndex;
            Console.WriteLine("Het gemiddelde kind is: {0}", kinderenGemiddelde);
            Console.WriteLine("Het oudste kind is: {0}", kinderenHoogste);

            int volwassenenTotaal = 0;
            int volwassenenHoogste = 0;

            Console.WriteLine("\n\nVOLWASSENEN");
            for (int i = 0; i < volwassenenIndex; i++)
            {
                Console.WriteLine("Volwassene {0} is {1}.", i + 1, volwassenenArray[i]);

                volwassenenTotaal += volwassenenArray[i];
                if (volwassenenArray[i] > volwassenenHoogste)
                {
                    volwassenenHoogste = volwassenenArray[i];
                }
            }

            float volwassenenGemiddelde = (float)volwassenenTotaal / (float)volwassenenIndex;
            Console.WriteLine("De gemiddelde volwassene is: {0}", volwassenenGemiddelde);
            Console.WriteLine("De oudste volwassene is: {0}", volwassenenHoogste);

            Console.ReadKey();
        }
    }
}
