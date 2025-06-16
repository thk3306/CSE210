public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;
    public ChecklistGoal(string name, string description, string points, int amountcompleted, int target, int bonus) : base(name, description, points)
    {
        _amountCompleted = amountcompleted;
        _target = target;
        _bonus = bonus;
    }
    public override int RecordEvent()
    {
        if (_amountCompleted < _target)
        {
            _amountCompleted++;
            Console.WriteLine($"Congratulations! You have completed the goal: {GetShortName()}");
            Console.WriteLine($"You have earned {GetPoints()} points!");
            if (_amountCompleted == _target)
            {
                Console.WriteLine($"You have also earned a bonus of {_bonus} points for completing the goal {_target} times!");
                return int.Parse(GetPoints()) + _bonus;
            }
        }
        else
        {
            Console.WriteLine("You have already completed this goal and aquired the bonus points.");
            Console.WriteLine($"You have earned {GetPoints()} points!");
        }
        return int.Parse(GetPoints());
    }
    public override bool IsComplete()
    {
        if (_amountCompleted == _target)
        {
            return true;
        }
        else return false;
    }
    public override string GetDetailsString()
    {
        return $"[ ]{GetShortName()} {GetDescription()} -- Currently completed: {_amountCompleted}/{_target}";
    }

    public override string GetStringRepresentation()
    {
        return $"{GetShortName()}|{GetDescription()}|{GetPoints()}|{_amountCompleted}|{_target}|{_bonus}|";
    }

    
}
    