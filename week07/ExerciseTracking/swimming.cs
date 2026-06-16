public class Swimming : Activity
{
    private double _laps;

    public Swimming(string date, double lengthMinutes, double laps)
        : base(date, lengthMinutes)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        return (_laps * 50) / 1000; // km
    }

    public override double GetSpeed()
    {
        return (GetDistance() / GetLengthMinutes()) * 60;
    }

    public override double GetPace()
    {
        return 60 / GetSpeed();
    }
}
