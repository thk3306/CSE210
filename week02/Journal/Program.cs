// I have exceeded the requirements of this assignment by adding a new exact time stamp to the journal entries. This helps to keep better track of exactly when the entry was made.

using System;
using System.IO.Enumeration;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal Program!");
        int choice = -1;
        Journal journal1 = new Journal();
        PromptGenerator newPrompt = new PromptGenerator();
        newPrompt._prompts.Add("Who stood out the most in your interactions today, and why?");
        newPrompt._prompts.Add("What was the highlight of your day?");
        newPrompt._prompts.Add("In what ways did you feel guided or blessed today?");
        newPrompt._prompts.Add("What emotion impacted you the most today, and what triggered it?");
        newPrompt._prompts.Add("If you could change one thing about today, what would it be and why?");
        while (choice != 5)
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.WriteLine("What would you like to do?");

            choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {

                string prompt = newPrompt.GetRandomPrompt();
                Console.WriteLine($"{prompt}");

                Entry newEntry = new Entry();
                newEntry._date = DateTime.Now.ToString("dd/MM/yyyy");

                newEntry._time = DateTime.Now.ToString("hh:mm tt");

                newEntry._promptText = prompt;
                Console.Write("> ");
                newEntry._entryText = Console.ReadLine();

                journal1.AddEntry(newEntry);
            }
            else if (choice == 2)
            {
                journal1.DisplayAll();
            }
            else if (choice == 3)
            {
                Console.WriteLine("What is the filename?");
                string file = Console.ReadLine();
                journal1.LoadFromFile(file);
            }
            else if (choice == 4)
            {
                Console.WriteLine("What is the filename?");
                string file = Console.ReadLine();
                journal1.SaveToFile(file);
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