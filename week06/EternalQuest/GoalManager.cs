using System.Net.Http.Headers;
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
            DisplayPlayerInfo();
            Console.WriteLine("Menu Options:\n 1. Create New Goal\n 2. List Goals\n 3. Save Goals\n 4. Load Goals\n 5. Record Event\n 6. Quit\n Select a choice from the menu: ");
            choice = int.Parse(Console.ReadLine());
            if (choice == 1)
            {
                CreateGoal();
            }
            else if (choice == 2)
            {
                Console.WriteLine("The Goals are:");
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
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetShortName()}");
        }
    }
    public void ListGoalDetails()
    {
        foreach (Goal goal in _goals)
        {
            if (goal.IsComplete())
            {
                Console.WriteLine($"[X] {goal.GetDetailsString()}");
            }
            else
            {
                Console.WriteLine($"[ ] {goal.GetDetailsString()}");
            }
        }
    }
    public void CreateGoal()
    {
        Console.WriteLine("The types of goals are: \n 1. Simple Goal\n 2. Eternal Goal\n 3. Checklist Goal\n 4. Bad Habit Goal");
        Console.Write("What type of goal would you like to create?");
        int choice = int.Parse(Console.ReadLine());
        if (choice == 1)
        {
            Console.WriteLine("What is the name of the goal?");
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
            Console.WriteLine("What is the name of your goal?");
            string name = Console.ReadLine();
            Console.WriteLine("What is a short description of it?");
            string description = Console.ReadLine();
            Console.WriteLine("What is the amount of points associated with this goal?");
            string points = Console.ReadLine();
            EternalGoal eternalGoal = new EternalGoal(name, description, points);
            _goals.Add(eternalGoal);
        }
        else if (choice == 3)
        {
            Console.WriteLine("What is the name of your goal?");
            string name = Console.ReadLine();
            Console.WriteLine("Write a short description of it?");
            string description = Console.ReadLine();
            Console.WriteLine("What is the amount of points associated with this goal?");
            string points = Console.ReadLine();
            Console.WriteLine("How many times does this goal need to be accomplished for a bonus?");
            int target = int.Parse(Console.ReadLine());
            Console.WriteLine("What is the bonus for accomplishing it that many times?");
            int bonus = int.Parse(Console.ReadLine());
            ChecklistGoal checklistgoal = new ChecklistGoal(name, description, points, 0, target, bonus);
            _goals.Add(checklistgoal);
        }
        else if (choice == 4)
        {
            Console.WriteLine("What is the name of your bad habit?");
            string name = Console.ReadLine();
            Console.WriteLine("Write a short description of it?");
            string description = Console.ReadLine();
            Console.WriteLine("What is the amount of negative points associated with this doing this?");
            string points = $"-{Console.ReadLine()}";
            SimpleGoal badHabitGoal = new SimpleGoal(name, description, points, false);
            _goals.Add(badHabitGoal);
        }
        else
        {
            Console.WriteLine($"'{choice}' is invalid, Please enter an integer between 1 and 4");
        }

    }
    public void RecordEvent()
    {
        Console.WriteLine("The goals are:");
        ListGoalNames();
        Console.WriteLine("Which goal did you accomplish? (Enter the number)");
        int choice = int.Parse(Console.ReadLine());
        if (choice < 1 || choice > _goals.Count)
        {
            Console.WriteLine("Invalid choice. Please try again.");
            return;
        }
        Goal selectedGoal = _goals[choice - 1];
        _score += selectedGoal.RecordEvent();
        DisplayPlayerInfo();
    }
    public void SaveGoals()
    {
        Console.WriteLine("What is the filename for the goals file?");
        string filename = Console.ReadLine();
        using (StreamWriter writer = new StreamWriter(filename))
        {
            writer.WriteLine($"Score:{_score}");
            foreach (Goal goal in _goals)
            {
                string goalType = goal.GetType().Name;
                writer.WriteLine($"{goalType}:{goal.GetStringRepresentation()}");
            }
        }
    }
    public void LoadGoals()
    {
        Console.WriteLine("What is the filename for the goals file?");
        string filename = Console.ReadLine();
        if (File.Exists(filename))
        {
            using var reader = new StreamReader(filename);
            string line;
            _goals.Clear();
            while ((line = reader.ReadLine()) != null)
            {
                if (string.IsNullOrWhiteSpace(line))
                    continue;

                if (line.StartsWith("Score:"))
                {
                    _score = int.Parse(line[6..]);
                }
                else if (line.StartsWith("SimpleGoal:"))
                {
                    string[] parts = line[11..].Split('|');
                    if (parts.Length >= 4)
                    {
                        var simpleGoal = new SimpleGoal(parts[0], parts[1], parts[2], bool.Parse(parts[3]));
                        _goals.Add(simpleGoal);
                    }
                }
                else if (line.StartsWith("EternalGoal:"))
                {
                    string[] parts = line[12..].Split('|');
                    if (parts.Length >= 3)
                    {
                        var eternalGoal = new EternalGoal(parts[0], parts[1], parts[2]);
                        _goals.Add(eternalGoal);
                    }
                }
                else if (line.StartsWith("ChecklistGoal:"))
                {
                    string[] parts = line[14..].Split('|');
                    if (parts.Length >= 6)
                    {
                        var checklistGoal = new ChecklistGoal(parts[0], parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[4]), int.Parse(parts[5]));
                        _goals.Add(checklistGoal);
                    }
                }
            }
        }
        else
        {
            Console.WriteLine($"File '{filename}' does not exist.");
        }
    }
    public int GetScore()
    {
        return _score;
    }
    
}