using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int secretNumber = 42;

            Console.WriteLine("Give me a number between 1 and 50!:");

            string res = Console.ReadLine();
            int num = int.Parse(res);

            if (num == secretNumber)
            {
                Console.WriteLine("You don't suck.");
            }
            else {
                Console.WriteLine("You suck.");
            }

        }
    }
}
