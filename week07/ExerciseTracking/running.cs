public class Running : Activity
{
    private double _distance; // miles or km (we use km here)

    public Running(string date, double lengthMinutes, double distance)
        : base(date, lengthMinutes)
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        return (_distance / GetLengthMinutes()) * 60;
    }

    public override double GetPace()
    {
        return 60 / GetSpeed();
    }
}
