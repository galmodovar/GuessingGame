using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int secretNumber = new Random().Next(1, 50);
            int guessesLeft = 0;
            int guesses = 0;
            int difficulty = 0;
            Console.WriteLine("Welcome to the guessing game");
            Console.WriteLine("Choose a difficulty level: 1 = Easy, 2 = Med, 3 = Hard");
            

            if (difficulty == 0)
            {
                string ans = Console.ReadLine();
                difficulty = int.Parse(ans);
                
                switch(difficulty)
                {
                    case 1:
                        guesses = 8;
                        Console.WriteLine($"You chose {guesses}");
                        break;
                    case 2:
                        guesses = 6;
                        Console.WriteLine($"You chose {guesses}");
                        break;
                    case 3:
                        guesses = 4;
                        Console.WriteLine($"You chose {guesses}");
                        break;
                    


                }
            }

            Console.WriteLine("Give me a number between 1 and 50!:");

            string res = Console.ReadLine();
            int num = int.Parse(res);

            while (guessesLeft + 1 < guesses) 
            {
            if (num == secretNumber)
            {
                Console.WriteLine("You don't suck.");
                break;
            }
            else {
                string clue = "too high";

                if (num < secretNumber)
                {
                    clue = "too low";
                }
                guessesLeft++;
                Console.WriteLine($"You suck, {clue}. Thats {guessesLeft} guess. You have  {guesses - guessesLeft}guesses left.");
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
