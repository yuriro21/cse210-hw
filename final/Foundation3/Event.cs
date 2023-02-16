using System;
using System.Threading;

public class Event
{
    protected string _eventTitle, _description, _date, _time;

    private List<Event> standardsDetails = new List<Event>();
    private List<Event> fullDetails = new List<Event>();
    private List<string> shortDetails = new List<string>();

    public string EventTitle { get => _eventTitle; set => _eventTitle = value; }
    public string Description { get => _description; set => _description = value; }
    public string Date { get => _date; set => _date = value; }
    public string Time { get => _time; set => _time = value; }
    public List<Event> StandardsDetails { get => standardsDetails; set => standardsDetails = value; }
    public List<Event> FullDetails { get => fullDetails; set => fullDetails = value; }
    public List<string> ShortDetails { get => shortDetails; set => shortDetails = value; }

    public Event()
    {
    }

    public Event(string eventTitle, string description, string date, string time)
    {
        _eventTitle = eventTitle;
        _description = description;
        _date = date;
        _time = time;
    }

    public void DisplayMenu()
    {
        Console.WriteLine("What kind of details do you want to see?: ");
        Console.WriteLine("   1. Standard");
        Console.WriteLine("   2. Full");
        Console.WriteLine("   3. Short");
    }
}