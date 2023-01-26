using System;

public class WritingAssignment : Assignmet
{
    private string _title = "";

    public WritingAssignment(string name, string topic, string title) : base (name, topic)
    {
        _title = title;
    }

    public string GetWritingInformation()
    {
        string studentName = GetName();
        return $"{_title} by {studentName}";
    }
}