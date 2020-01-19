using System;

namespace Opdracht_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int score = 0;
            char grade = 'A';

            Console.Write("Enter score: ");
            score = int.Parse(Console.ReadLine());
            Console.WriteLine();

            if (score >= 90)
            {
                grade = 'A';
            }
            else if (score < 89 && score >= 80)
            {
                grade = 'B';
            }
            else if (score < 79 && score >= 70)
            {
                grade = 'C';
            }
            else if (score < 69 && score >= 60)
            {
                grade = 'D';
            } 
            else if (score < 60)
            {
                grade = 'F';
            }

            Console.WriteLine("Grade: {0}", grade);

            if (score >= 70)
            {
                Console.WriteLine("Course passed");
            }
            else
            {
                Console.WriteLine("Course not passed");
            }

            Console.ReadKey();
        }
    }
}
