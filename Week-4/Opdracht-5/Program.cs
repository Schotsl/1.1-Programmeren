using System;

namespace Opdracht_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Geef een jaartal: ");
            int year = int.Parse(Console.ReadLine());

            while (year != 0)
            {
                if (year < 0)
                {
                    Console.WriteLine("Dit is geen geldig jaartal");
                }
                else
                {
                    if (year % 400 == 0 || year % 100 != 0 && year % 4 == 0)
                    {
                        Console.WriteLine("{0} is een schrikkeljaar", year);
                    }
                    else
                    {
                        Console.WriteLine("{0} is geen schrikkeljaar", year);
                    }

                    Console.Write("\nGeef een jaartal: ");
                    year = int.Parse(Console.ReadLine());
                }
            }
        }
    }
}
