// I have exceeded the requirements of this assignments by adding an option for the user to enter a custom scripture reference and text to memorise.

using System;
using System.Xml.Serialization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Do you want to enter a custom Scripture verse? (Enter 'no' to use the default of Proverbs 3:5-6)");
        string choice = Console.ReadLine().ToLower();
        if (choice == "no")
        {
            Reference reference2 = new Reference("Proverbs", 3, 5, 6);
            Scripture scripture2 = new Scripture(reference2, "Trust in the Lord with all your heart and lean not on your own understanding; in all your ways submit to him, and he will make your paths straight.");
            Console.WriteLine($"{scripture2.GetDisplayText()}");
            string choice2 = "default";
            while (choice2 != "quit" && !scripture2.IsCompletelyHidden())
            {
                Console.WriteLine("Press enter to continue or type 'quit' to finish");
                choice2 = Console.ReadLine();
                Console.Clear();
                if (choice2 != "quit")
                {
                    scripture2.HideRandomWords(3);
                    Console.WriteLine($"{scripture2.GetDisplayText()}");
                }
            }

        }
        else if (choice != "no")
        {
            Console.WriteLine("What is the scripture reference? (Format: John 3:16 or Book Proverbs 3:5-6)");
            string reference = Console.ReadLine();
            Console.WriteLine("What is the scripture text?");
            string text = Console.ReadLine();
            string[] parts = reference.Split(' ');
            string book = parts[0];
            int chapter = int.Parse(parts[1].Split(':')[0]);
            int verse = int.Parse(parts[1].Split(':')[1].Split('-')[0]);
            int endVerse = 0;
            if (parts[1].Contains('-'))
            {
                endVerse = int.Parse(parts[1].Split('-')[1]);
            }
            else
            {
                endVerse = verse;
            }
            Reference reference1 = new Reference(book, chapter, verse, endVerse);
            Scripture scripture1 = new Scripture(reference1, text);
            Console.Clear();
            Console.WriteLine($"{scripture1.GetDisplayText()}");
            string choice2 = "default";
            while (choice2 != "quit" && !scripture1.IsCompletelyHidden())
            {
                Console.WriteLine("Press enter to continue or type 'quit' to finish");
                choice = Console.ReadLine();
                Console.Clear();
                if (choice2 != "quit")
                {
                    scripture1.HideRandomWords(3);
                    Console.WriteLine($"{scripture1.GetDisplayText()}");
                }
            }
        }
        Console.WriteLine($"Thanks for Using this Program!");
    }
}