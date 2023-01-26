using System;

public class Assignmet
{
    private string _studentName = "";
    private string _topic = "";

    public Assignmet(string name, string topic)
    {
        _studentName = name;
        _topic = topic;
    }

    public string GetSummary()
    {
        return _studentName + " - " + _topic;
    }

    public string GetName()
    {
        return _studentName;
    }
}