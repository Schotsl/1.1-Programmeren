using System;

namespace Opdracht_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Geef uw naam: ");
            string naam = Console.ReadLine();

            Console.Write("Geef uw leeftijd: ");
            string leeftijd = Console.ReadLine();

            Console.WriteLine("\nUw naam is " + naam);
            Console.WriteLine("Uw leeftijd is " + leeftijd);

            Console.ReadKey();
        }
    }
}
