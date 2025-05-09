using System;

class Program
{
    static void Main(string[] args)
    {
        
        
        int guess = 0;
        string guessInput = string.Empty;
        string input = string.Empty;
        int magicNumber = 0;
        Console.WriteLine("Welcome to the Magic Number Game!");
        magicNumber = new Random().Next(1, 101);
        do {
        Console.WriteLine("What is your guess?");
        guessInput = Console.ReadLine();
        guess = int.Parse(guessInput);
        if (guess == magicNumber)
        {
            Console.WriteLine("You Guessed it!");
        }
        else if (guess < magicNumber)
        {
            Console.WriteLine("Higher");
        }
        else if (guess > magicNumber)
        {
            Console.WriteLine("Lower");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a number.");
                }
            }
            while (guess != magicNumber);
        Console.WriteLine("Would you like to play again? (y/n)");
        input = Console.ReadLine();
        if (input.ToLower() == "y")
        {
            Main(args); // Restart the game
        }
        else if (input.ToLower() == "n")
        {
            Console.WriteLine("Thanks for playing!");
        }
        else
        {
            Console.WriteLine("Invalid input. Exiting the game.");
        }
    }
}
