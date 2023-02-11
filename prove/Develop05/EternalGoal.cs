using System;
using System.IO;

public class EternalGoal : Goal
{
    private bool _goalComplete;
    private const int goalType = 1;

    public EternalGoal()
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
        // Thread.Sleep(4000);
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