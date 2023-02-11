using System;
using System.Threading;
using System.IO;

public abstract class Goal
{
    
    protected string _name, _description;
    protected int _points;
    public Goal()
    {
    }

    //public abstract int RecordEvent();

    //public abstract bool IsComplete();

    public abstract string ToCSVRecord();

    public string setName()
    {
        Console.WriteLine("What is the name of your goal? ");
        _name = Console.ReadLine();
        return _name;
    }

    public string getName()
    {
        return _name;
    }

    public string setDescription()
    {
        Console.WriteLine("What is a short description of it? ");
        _description = Console.ReadLine();
        return _description;
    }

    public string getDescription()
    {
        return _description;
    }

    public int setPoints()
    {
        Console.WriteLine("What is the amount of points associated with this goal? ");
        _points = int.Parse(Console.ReadLine());
        return _points;
    }

    public int getPoints()
    {
        return _points;
    }
}