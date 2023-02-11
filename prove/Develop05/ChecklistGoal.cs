using System;
using System.IO;

public class ChecklistGoal : Goal
{   
    protected int _timesToAcomplish, _bonus;
    private bool _goalComplete;
    private const int goalType = 1;

    public ChecklistGoal()
    {

    }

    public void runActivity()
    {
        setName();
        setDescription();
        setPoints();
        setTimesToAcomplish();
        setBonus();
        // Console.WriteLine("____________");
        // Console.WriteLine(getName());
        // Console.WriteLine(getDescription());
        // Console.WriteLine(getPoints());
        // Console.WriteLine(getTimesToAcomplish());
        // Console.WriteLine(getBonus());
        
        // Thread.Sleep(4000);
    }
    
    public int setTimesToAcomplish()
    {
        Console.WriteLine("How many times does this goal need to be accomplished for a bonus? ");
        _timesToAcomplish = int.Parse(Console.ReadLine());
        return _timesToAcomplish;
    }
    
    public int getTimesToAcomplish()
    {
        return _timesToAcomplish;
    }

    public int setBonus()
    {
        Console.WriteLine("What is the bonus for accomplishing it that many times? ");
        _bonus = int.Parse(Console.ReadLine());
        return _bonus;
    }

    public int getBonus()
    {
        return _bonus;
    }

    public override string ToString()
    {
        return string.Format("* [{0}] {1} ({2}) --- Currently complete: 0/{3}",((_goalComplete == false) ? " " : "X"), getName(), getDescription(), getTimesToAcomplish());
    }
    public override string ToCSVRecord()
    {
        return string.Format("{0}|{1}|{2}|{3}|{4}|{5}|{6}", goalType, getName(), getDescription(), getPoints(), _goalComplete, getBonus(), getTimesToAcomplish());
    } 
}
