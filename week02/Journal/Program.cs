using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal Program!");
        Console.WriteLine("Please select one of the following choices:");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");
        Console.Write("What would you like to do? \n");
        int choice = -1;

        while (choice != 5)
        {
            choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                
            }
            else if (choice == 2)
            {

            }
            else if (choice == 3)
            {

            }
            else if (choice == 4)
            {

            }
            else if (choice == 5)
            {
            Console.Write("Thanks for using the Journal Program, Bye!");
            }
            
            else
            {
                Console.Write($"'{choice}' is invalid, please enter a number between 1 and 5 \n");
            }
        }
        
        

    }
}