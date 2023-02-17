using System;

public class Swimming : Activity
{   
    private int _laps;
    public Swimming(string _date, double _duration, int laps) : base (_date, _duration)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        return _laps * 50 / 1000 * 0.62;
    }

    public override double GetSpeed()
    {
        return (GetDistance() / Duration) * 60;
    }

    public override double GetPace()
    {
        return Duration / GetDistance();
    }
}