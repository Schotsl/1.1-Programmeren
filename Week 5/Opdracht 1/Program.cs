using System;

namespace Opdracht_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[20];

            int i;
            int min = 0;
            int max = 200;
            float difference, avg, total = 0;

            Random randNum = new Random();
            for (i = 0; i < nums.Length; i++)
            {
                nums[i] = randNum.Next(min, max);
                Console.WriteLine($"Element {i} is {nums[i]}");
                total += nums[i];
            }

            avg = (total / nums.Length);
            Console.WriteLine($"\nHet gemiddelde is: {avg}\n");

            foreach(int num in nums)
            {
                difference = Math.Abs(num - avg);
                Console.WriteLine($"Verschil gemiddelde en element {i} is {difference}");
                i++;
            }

            Console.ReadKey();
        }
    }
}
