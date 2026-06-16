using System;

public abstract class Activity
{
    private string _date;
    private double _lengthMinutes;

    public Activity(string date, double lengthMinutes)
    {
        _date = date;
        _lengthMinutes = lengthMinutes;
    }

    public string GetDate()
    {
        return _date;
    }

    public double GetLengthMinutes()
    {
        return _lengthMinutes;
    }

    // ABSTRACT METHODS (REQUIRED BY RUBRIC)
    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    // SUMMARY METHOD (MUST BE IN BASE CLASS)
    public virtual string GetSummary()
    {
        return $"{_date} {GetType().Name} ({_lengthMinutes} min) - " +
               $"Distance {GetDistance():0.0}, Speed {GetSpeed():0.0}, Pace: {GetPace():0.0}";
    }
}
