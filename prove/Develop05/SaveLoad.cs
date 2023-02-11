using System;
using System.IO;
using System.Collections.Generic;

public class SaveLoad
{
    protected string _path = @"C:\Users\ediss\OneDrive\Documentos\Pathway\cse210-hw\cse210-hw\prove\Develop05\Files\";
    protected string _fileName, _fullPath;

    public SaveLoad()
    {
    }

    public string SetFileName()
    {
        Console.WriteLine("What is the filename for the goal file? ");
        _fileName = Console.ReadLine();
        return _fileName;
    }

    public void SaveToCSV(List<string> saveGoal, string fileName)
    {
        _fullPath = _path + _fileName;
        using (StreamWriter outputFile = new StreamWriter(_fullPath))
        {
            outputFile.WriteLine(saveGoal);
        }
    } 

}