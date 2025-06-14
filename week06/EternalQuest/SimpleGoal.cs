using System.Diagnostics.Contracts;

public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string shortname, string description, string points, bool iscomplete) : base(shortname, description, points)
    {
        _isComplete = false;
    }

    public override void RecordEvent()
    {

    }
    public override bool IsComplete()
    {
        _isComplete = true;
        return _isComplete;
    }

    public override string GetStringRepresentation()
    {
        return base.GetStringRepresentation();
    }

}