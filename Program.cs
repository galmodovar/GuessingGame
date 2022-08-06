using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int secretNumber = 42;
            int guesses = 0;

            Console.WriteLine("Give me a number between 1 and 50!:");

            string res = Console.ReadLine();
            int num = int.Parse(res);

            while (guesses < 4) 
            {
            if (num == secretNumber)
            {
                Console.WriteLine("You don't suck.");
                break;
            }
            else {
                guesses++;
                Console.WriteLine($"You suck. {5 - guesses} guesses left.");
                res = Console.ReadLine();
                num = int.Parse(res);
            }
            }

            if (num != secretNumber)
            {
                Console.WriteLine("All out of guesses.");
            }


        }
    }
}
