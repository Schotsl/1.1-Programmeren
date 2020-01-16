using System;

namespace Opdracht_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Geef prijs: ");
            float price = float.Parse(Console.ReadLine());

            float btw = BerekenBtw(price);
            float total = btw + price;

            Console.WriteLine("\nPrijs: {0}, BTW: {1}, totaal: {2}", price, btw, total);
            Console.ReadKey();
        }

        static float BerekenBtw(float price) {
            float btw = price * (float)0.21;
            return btw;
        }
    }
}
