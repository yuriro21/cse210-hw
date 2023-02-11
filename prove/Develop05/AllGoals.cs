using System;
using System.Collections.Generic;
using System.Threading;
using System.IO;


public class AllGoals
{
    private List<string> allGoals = new List<string>();

    public void addGoal(string _goal)
    {
        allGoals.Add(_goal);
    }

    public void DisplayGoals()
    {
        if (allGoals.Count() == 0)
        {
            Console.WriteLine("No goals have been created or loaded.");
        }
        foreach (string goal in allGoals)
        {
            Console.WriteLine(goal.ToString());
        }
    }

    public void SaveGoal()
    {
        SaveLoad SL = new SaveLoad();
        if (allGoals.Count() == 0)
        {
            Console.WriteLine("There are no goals to save.");
            return;
        }
        SaveLoad save = new SaveLoad();
        string fileName = save.SetFileName();

        List<string> saveGoals = new List<string>();

        foreach (string goal in allGoals)
        {
            saveGoals.Add(goal);
        }

        SL.SaveToCSV(saveGoals, fileName);

        Console.WriteLine("Goals saved");
    }
}

