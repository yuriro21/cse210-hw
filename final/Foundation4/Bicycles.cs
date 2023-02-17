using System;

public class Bicycles : Activity
{
    public Bicycles(double _speed, string _date, double _duration) : base (_speed, _date, _duration)
    {
    }

    public override double GetDistance()
    {
        return (Speed / 60) * Duration;
    }

    public override double GetSpeed()
    {
        return Speed;
    }

    public override double GetPace()
    {
        return 60 / Speed;
    }    
}