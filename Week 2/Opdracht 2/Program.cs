using System;

namespace Opdracht_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Geef getal 1: ");
            int numberOne = int.Parse(Console.ReadLine());

            Console.Write("Geef getal 2: ");
            int numberTwo = int.Parse(Console.ReadLine());

            Console.Write("Geef getal 3: ");
            int numberThree = int.Parse(Console.ReadLine());

            double numberAverage = (numberOne + numberTwo + numberThree) / (double)3;
            Console.WriteLine("\nGemiddelde: {0}", numberAverage.ToString());
            Console.ReadKey();
        }
    }
}
