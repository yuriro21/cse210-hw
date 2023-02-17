using System;

public class Running : Activity
{
    public Running(string _date, double _duration, double _distance) : base (_date, _duration, _distance)
    {
    }

    public override double GetDistance()
    {
        return Distance;
    }

    public override double GetSpeed()
    {
        return 60 / GetPace();
    }

    public override double GetPace()
    {
        return Duration / Distance;
    }
}