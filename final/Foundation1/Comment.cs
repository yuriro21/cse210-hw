using System;

public class Comment
{
    private string _name, _comments;
    public Comment()
    {
    }

    public Comment(string name, string comment)
    {
        Name = name;
        Comments = comment;
    }

    public string Name { get => _name; set => _name = value; }
    public string Comments { get => _comments; set => _comments = value; }
    
    public string ToString()
    {
        return string.Format("{0}|{1}", Name, Comments);
    }
}