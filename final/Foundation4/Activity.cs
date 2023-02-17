using System;

public abstract class Activity
{   
    private double _distance, _speed, _pace, _duration;
    private string _date;

    public double Distance { get => _distance; set => _distance = value; }
    public double Speed { get => _speed; set => _speed = value; }
    public double Pace { get => _pace; set => _pace = value; }
    public string Date { get => _date; set => _date = value; }
    public double Duration { get => _duration; set => _duration = value; }

    public Activity(string date, double duration)
    {
        _date = date;
        _duration = duration;
    }

    public Activity(string date, double duration, double distance)
    {
        _date = date;
        _duration = duration;
        _distance = distance;
    }

    public Activity(double speed, string date, double duration)
    {
        _speed = speed;
        _date = date;
        _duration = duration;
    }

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();
    
    public string GetSumary()
    {
        return string.Format("{0} ({1} min)- Distance {2} miles, Speed {3} mph, Pace: {4} min per mile", Date, Duration, GetDistance(), GetSpeed(), GetPace());
    }
}