using System;
using System.IO;
using System.Collections.Generic;

public class SaveLoad
{
    protected string _path = "C:\\Users\\ediss\\OneDrive\\Documentos\\Pathway\\cse210-hw\\cse210-hw\\prove\\Develop05\\Files\\"; 
    protected string _fileName, _fullPath;

    public SaveLoad()
    {
    }

    public string SetFileName()
    {
        Console.WriteLine(_path);
        Console.WriteLine("What is the filename for the goal file? ");
        _fileName = Console.ReadLine() + ".txt";
        return _fileName;
    }

    public void SaveToCSV(List<string> saveGoal, string fileName)
    {
        _fullPath = _path + _fileName;
        using (StreamWriter outputFiles = new StreamWriter(_fullPath))
        {
            outputFiles.WriteLine(saveGoal);
        }
    } 

    public void LoadFile()
    {
        Console.WriteLine("What is the name of the file? ");
        string fileName = Console.ReadLine();
        string [] lines = System.IO.File.ReadAllLines(fileName);
        foreach (string line in lines)
        {
            string [] parts = line.Split("|");
            int goalType = int.Parse(parts[0]);
            switch(goalType)
            {
                case 1:
                
                    break;

            }

        }
    }
}