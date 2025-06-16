using System.Security.Cryptography;

public class GoalManager
{
    private List<Goal> _goals;
    private int _score;
    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public void Start()
    {
        int choice = 0;
        while (choice != 6)
        {
            Console.WriteLine("Menu Options:\n 1. Create New Goal\n 2. List Goals\n 3. Save Goals\n 4. Load Goals\n 5. Record Event\n 6. Quit\n Select a choice from the menu: ");
            choice = int.Parse(Console.ReadLine());
            if (choice == 1)
            {
                CreateGoal();
            }
            else if (choice == 2)
            {
                ListGoalNames();
                ListGoalDetails();
            }
            else if (choice == 3)
            {
                SaveGoals();
            }
            else if (choice == 4)
            {
                LoadGoals();
            }
            else if (choice == 5)
            {
                RecordEvent();
            }
            else if (choice == 6)
            {
                Console.Clear();
                Console.WriteLine("Goodbye!");
            }
            else
            {
                Console.Clear();
                Console.WriteLine($"'{choice}' is invalid, Please enter an integer between 1 and 6");
            }
        }
    }
    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"You have {_score} points.\n");
        
    }
    public void ListGoalNames()
    {

    }
    public void ListGoalDetails()
    {

    }
    public void CreateGoal()
    {
        Console.WriteLine("The types of goals are: \n 1. Simple Goal\n 2. Eternal Goal\n 3. Checklist Goal\n");
        Console.Write("What type of goal would you like to create?");
        int choice = int.Parse(Console.ReadLine());
        if (choice == 1)
        {
            Console.WriteLine("What is the name of the goals?");
            string name = Console.ReadLine();
            Console.WriteLine("Write a short description of the goal:");
            string description = Console.ReadLine();
            Console.WriteLine("What is the amount of points associated with this goal?");
            string points = Console.ReadLine();
            SimpleGoal simpleGoal = new SimpleGoal(name, description, points, false);
            _goals.Add(simpleGoal);
        }
        else if (choice == 2)
        {
            Console.WriteLine("What is the name of the goal?");
            string name = Console.ReadLine();
            Console.WriteLine(:Write a 

        }
        
    }
    public void RecordEvent()
    {

    }
    public void SaveGoals()
    {

    }
    public void LoadGoals()
    {
        
    }

}