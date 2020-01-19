using System;

namespace Opdracht_3
{
    class Program
    {
        static void Main(string[] args)
        {

            int aantal = 4;

            int scoreOud = 200;
            int levelOud = 3;

            int scoreNieuw;
            int levelNieuw;
   
            scoreNieuw = scoreOud + 1;
            levelNieuw = levelOud + 1;

            Console.WriteLine("Score (oud): {0}, score (nieuw): {1}", scoreOud, scoreNieuw);
            Console.WriteLine("level (oud): {0}, level (nieuw): {1}", levelOud, levelNieuw);
            
            aantal += 5;
            
            Console.WriteLine("\naantal items: {0}", aantal);
            Console.ReadKey();
        }
    }
}
