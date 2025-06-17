public abstract class Activity
{
    private DateTime _date;
    private int _length;

    public Activity(DateTime date, int length)
    {
        _date = date;
        _length = length;
    }

    public abstract double GetSpeed();
    public abstract double GetPace();
    public abstract double GetDistance();
    public abstract string GetSummary();

    public int GetLength()
    {
        return _length;
    }

    public DateTime GetDate()
    {
        return _date;
    }
}