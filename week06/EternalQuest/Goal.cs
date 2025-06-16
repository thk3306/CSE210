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
    public abstract int RecordEvent();

    public virtual bool IsComplete()
    {
        return false;
    }
    public string GetShortName()
    {
        return _shortName;
    }

    public string GetDescription()
    {
        return _description;
    }

    public string GetPoints()
    {
        return _points;
    }

    public virtual void SetShortName(string shortname)
    {
        _shortName = shortname;
    }

    public virtual void SetDescription(string description)
    {
        _description = description;
    }

    public virtual void SetPoints(string points)
    {
        _points = points;
    }

    public virtual string GetDetailsString()
    {
        return $"{GetShortName()} ({GetDescription()})";
    }
    public virtual string GetStringRepresentation()
    {
        return $"{GetShortName()}|{GetDescription()}|{GetPoints()}";
    }
}