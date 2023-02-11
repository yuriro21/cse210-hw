using System;

public class Video
{
    private string _title, _author;
    private int _seconds;
    List<string> coments;

    public Video()
    {
    }

    public Video(string title, string author, int seconds, List<string> coments)
    {
        Title = title;
        Author = author;
        Seconds = seconds;
        this.Coments = coments;
    }

    public string Title { get => _title; set => _title = value; }
    public string Author { get => _author; set => _author = value; }
    public int Seconds { get => _seconds; set => _seconds = value; }
    public List<string> Coments { get => coments; set => coments = value; }

    public void GetAllComments()
    {   
        foreach (string singleComment in Coments)
        {
            string[] str = singleComment.Split("|");
            Console.WriteLine("Person: " + str[0] + "\nComent: " + str[1] + "\n");
        }
    }
}