// I have exceeded the requirements of the assignment by adding a counter for each activity type which then is display when the user chooses to quit the program. This provides a summary of how many times each activity was used during the session.
using System;
using System.ComponentModel.Design;

class Program
{
    static void Main(string[] args)
    {
        int choice = 0;
        int activityCount1 = 0;
        int activityCount2 = 0;
        int activityCount3 = 0;
        while (choice != 4)
        {
            Console.WriteLine("Menu Options: \n 1. Start breathing activity\n 2. Start reflecting activity\n 3. Start listing activity\n 4. Quit\n Select a choice from the menu:");
            choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                Console.Clear();
                BreathingActivity breathingActivity = new BreathingActivity();
                breathingActivity.Run();
                activityCount1++;
                Console.Clear();
            }
            else if (choice == 2)
            {
                Console.Clear();
                ReflectingActivity reflectingActivity = new ReflectingActivity();
                reflectingActivity.Run();
                activityCount2++;
                Console.Clear();
            }
            else if (choice == 3)
            {
                Console.Clear();
                ListingActivity listingActivity = new ListingActivity();
                listingActivity.Run();
                activityCount3++;
                Console.Clear();
            }
            else if (choice == 4)
            {
                Console.Clear();
                Console.WriteLine($"Thank you for using the Program! \n Here's how many times you used each activity!\n Breathing Activity: {activityCount1}\n Reflecting Activity: {activityCount2}\n Listing Activity: {activityCount3}\n Goodbye :)");
            }
            else
            {
                Console.Clear();
                Console.WriteLine($"'{choice}' is invalid, Please enter an integer between 1 and 4");
            }
        }
    }
}