using System;

namespace Opdracht_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOne = 0;
            int numberTwo = 1;

            Console.Write("{0} {1}", numberOne, numberTwo); 

            for (int i = 2; i < 20; ++i)   
            {
                int numberThree = numberOne + numberTwo;
                Console.Write("{0} ", numberThree);
                numberOne = numberTwo;
                numberTwo = numberThree;
            }
        }
    }
}
