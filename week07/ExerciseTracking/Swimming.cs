public class Swimming : Activity
{
    private int _laps;

    public Swimming(DateTime date, int length, int laps) : base(date, length)
    {
        _laps = laps;
    }
    public override double GetSpeed()
    {
        return _laps / (GetLength() / 60.0);
    }
    public override double GetPace()
    {
        return GetLength() / (double)_laps;
    }
    public override double GetDistance()
    {
        return _laps * 50 / 1000.0;
    }
    public override string GetSummary()
    {
        return $"{GetDate()} Swimming ({GetLength()} mins) - Laps: {_laps}, Speed: {GetSpeed():F2} laps/min, Pace: {GetPace():F2} min/lap, Distance: {GetDistance():F2} km";
    }
}