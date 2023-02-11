using System;
using System.IO;

public class EternalGoal : Goal
{
    private bool _goalComplete;
    public EternalGoal()
    {
    }

    public void runActivity()
    {
        setName();
        setDescription();
        setPoints();
        // Console.WriteLine("_____-----_______");
        // Console.WriteLine(getName());
        // Console.WriteLine(getDescription());
        // Console.WriteLine(getPoints());
        // Thread.Sleep(4000);
    }
    public override string ToString()
    {
        return string.Format("* [{0}] {1} ({2})",((_goalComplete == false) ? " " : "X"), getName(), getDescription());
    }
}