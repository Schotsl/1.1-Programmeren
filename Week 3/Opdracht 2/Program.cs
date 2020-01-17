using System;

namespace Opdracht_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number (1..4): ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine();

            if (number <= 0 || number >= 5)
            {
                Console.WriteLine("Invalid number");
            }
            else
            {
                switch (number)
                {
                    case 1:
                        Console.WriteLine("Klaveren");
                        break;
                    case 2:
                        Console.WriteLine("Ruiten");
                        break;
                    case 3:
                        Console.WriteLine("Harten");
                        break;
                    case 4:
                        Console.WriteLine("Schoppen");
                        break;
                }
            }

            Console.ReadKey();
        }
    }
}
