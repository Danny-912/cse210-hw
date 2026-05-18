using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");

        string playAgain = "yes";

        while (playAgain.ToLower() == "yes")
        {
            // Generate a random magic number from 1 to 100
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 101);

            int guess = -1;
            int guessCount = 0;

            // Keep looping until the user guesses correctly
            while (guess != magicNumber)
            {
                Console.Write("What is your guess? ");
                string input = Console.ReadLine();

                guess = int.Parse(input);

                guessCount++;

                if (guess < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else if (guess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                }
            }

            // Display number of guesses
            Console.WriteLine($"You made {guessCount} guesses.");

            // Ask if the user wants to play again
            Console.Write("Do you want to play again? (yes/no) ");
            playAgain = Console.ReadLine();
        }

        Console.WriteLine("Thanks for playing!");
    }
}
    
