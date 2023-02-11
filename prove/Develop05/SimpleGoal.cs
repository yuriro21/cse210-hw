using System;
using System.Threading;
using System.IO;


public class SimpleGoal : Goal
{
    private const int goalType = 1;
    private bool _goalComplete;
    public SimpleGoal() : base ()
    {
    }

    public void runActivity()
    {
        setName();
        setDescription();
        setPoints();
        // Console.WriteLine("____________");
        // Console.WriteLine(getName());
        // Console.WriteLine(getDescription());
        // Console.WriteLine(getPoints());
        // Thread.Sleep(2000);
    }

    public override string ToString()
    {
        return string.Format("* [{0}] {1} ({2})",((_goalComplete == false) ? " " : "X"), getName(), getDescription());
    }

    public override string ToCSVRecord()
    {
        return string.Format("{0}|{1}|{2}|{3}|{4}", goalType, getName(), getDescription(), getPoints(), _goalComplete);
    }
}