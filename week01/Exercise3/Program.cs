using System;

class Program
{
    static void Main(string[] args)
    {
        // Random number generator
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);

        int guess = -1; // Initialize guess with a value that will not equal the magic number

        Console.WriteLine();
        Console.WriteLine("I'm thinking of a number between 1 and 100...");
        List<int> GuessCount = new List<int>();

        while (guess != magicNumber)
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());
            GuessCount.Add(guess);

            if (guess < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else if (guess > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else if (guess == magicNumber)
            {
                Console.WriteLine();
                Console.WriteLine("You guessed it!");
                Console.WriteLine($"It took you {GuessCount.Count()} guesses.");

                Console.Write("Would you like to continue (Yes/No): ");
                string ContinueGame = Console.ReadLine().Trim().ToLower();
                if (ContinueGame == "yes" || ContinueGame == "y")
                {
                    continue;
                }
                else
                {
                    Console.WriteLine("Thank you for playing. Goodby!");
                    Console.WriteLine();
                    break;
                }
            }
        }    
    }
}