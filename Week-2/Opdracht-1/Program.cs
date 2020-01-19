using System;

namespace Opdracht_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Geef prijs: ");
            double price = double.Parse(Console.ReadLine());

            double btw = price * 0.21;
            double total = btw + price;

            Console.WriteLine("\nPrijs: {0}, BTW: {1}, totaal: {2}", price, btw, total);
            Console.ReadKey();
        }
    }
}
