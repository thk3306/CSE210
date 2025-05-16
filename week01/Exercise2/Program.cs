    using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage?");
        string input = Console.ReadLine();
        string gradeLetter = string.Empty;
        int gradePercentage = int.Parse(input);
        if (gradePercentage >= 90)
        {
            gradeLetter = "A";
        }
        else if (gradePercentage >= 80)
        {
            gradeLetter = "B";
        }
        else if (gradePercentage >= 70)
        {
            gradeLetter = "C";
        }
        else if (gradePercentage >= 60)
        {
            gradeLetter = "D";
        }
        else
        {
            gradeLetter = "F";
        }
        Console.WriteLine($"Your grade letter is {gradeLetter}.");
        if (gradePercentage >= 70)
        {
            Console.WriteLine("You passed the class! Congrtulations!");
        }
        else
        {
            Console.WriteLine("You failed the class. Better luck next time!");
        }
    }
}