using System;

namespace Opdracht_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Geef aantal seconden: ");
            int seconden = int.Parse(Console.ReadLine());

            int uren = seconden / 3600;
            seconden -= uren * 3600;

            int minuten = seconden / 60;
            seconden -= minuten * 60;

            Console.WriteLine("\n{0:00}:{1:00}:{2:00}", uren, minuten, seconden);
            Console.ReadKey();
        }
    }
}
