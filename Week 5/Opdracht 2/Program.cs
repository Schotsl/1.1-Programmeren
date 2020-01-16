using System;

namespace Opdracht_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            int[] nums = new int[20];

            int min = 0;
            int max = 150;

            int smallgang = 0;
            float total = 0;

            Random randNum = new Random();
            
            for (i = 0; i < nums.Length; i++)
            {
                nums[i] = randNum.Next(min, max);
                Console.WriteLine($"Element {i} is {nums[i]}");
                total += nums[i];

            }

            int smallest = nums[0];
            for (i = 0; i < nums.Length; i++)
            {
                if (smallest > nums[i])
                {
                    smallest = nums[i];
                } else if (smallest == nums[i])
                {
                    smallgang++;
                }
            }

            Console.WriteLine($"\nHet kleinste getal {smallest} en daar zijn er {smallgang} van.");
            Console.ReadKey();
        }
    }
}
