using System;

namespace Opdracht_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Geef uw leeftijd: ");

            int leeftijd = int.Parse(Console.ReadLine());
            bool oud = leeftijd >= 65;
            
            Console.WriteLine("\nWaarde van oud: {0}", oud);
            Console.ReadKey();
        }
    }
}
