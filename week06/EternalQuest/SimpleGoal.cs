using System.Diagnostics.Contracts;

public class SimpleGoal : Goal
{
    protected bool _isComplete;

    public SimpleGoal(string shortname, string description, string points, bool iscomplete) : base(shortname, description, points)
    {
        _isComplete = false;
    }

    public override int RecordEvent()
    {
        if (int.Parse(GetPoints()) <= 0)
        {
            Console.WriteLine("You did a bad thing, you lose points!");
            Console.WriteLine($"You have lost {GetPoints()} points!");
            return int.Parse(GetPoints());
        }
        else Console.WriteLine($"Congratulations! You have completed the goal: {GetShortName()}");
            _isComplete = true;
            Console.WriteLine($"You have earned {GetPoints()} points!");
            return int.Parse(GetPoints());
    }
    public override bool IsComplete()
    {
        return _isComplete;
    }
    public override string GetStringRepresentation()
    {
        return base.GetStringRepresentation();
    }
}