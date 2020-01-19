using System;

namespace Opdracht_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Geef uw leeftijd: ");
            
            string leeftijdString = Console.ReadLine();
            int leeftijdInt = int.Parse(leeftijdString);

            leeftijdInt += 1;
            leeftijdString = leeftijdInt.ToString();

            Console.WriteLine("\nVolgend jaar bent u " + leeftijdString + " jaar oud.");
            Console.ReadKey();
        }
    }
}
