public abstract class Goal
{
    private string _shortName;
    private string _description;
    private string _points;

    public Goal(string shortname, string description, string points)
    {
        _shortName = shortname;
        _description = description;
        _points = points;
    }
    public abstract void RecordEvent();
    public virtual bool IsComplete()
    {
        return false;
    }
    public virtual string GetDetailsString()
    {
        return "";
    }
    public virtual string GetStringRepresentation()
    {
        return "";
    }
}