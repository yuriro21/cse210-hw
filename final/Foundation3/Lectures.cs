using System;
using System.Threading;
public class Lectures : Event
{
    private string _speaker;
    private int _capacity;
    public Lectures() : base()
    {}
    public Lectures(string _eventTitle, string _description, string _date, string _time, string speaker, int capacity) : base(_eventTitle, _description, _date, _time)
    {
        _speaker = speaker;
        _capacity = capacity;
    }

    public override string ToString()
    {
        return string.Format("{0}|{1}|{2}|{3}|{4}|{5}", _eventTitle, _description, _date, _time, _speaker, _capacity);
    }
    
    public void GetShortDetails()
    {
        foreach (string item in ShortDetails)
        {   
            string[] str = item.Split("|");
            Console.WriteLine($"-Type event: Lecture \n-Title: {str[0]} \n-Date: {str[2]}");
            Thread.Sleep(4000);
        }
    }

    public void GetStandardDetails(string address)
    {
        foreach (string item in ShortDetails)
        {   
            string[] str = item.Split("|");
            Console.WriteLine($"-Title: {str[0]} \n-Description: {str[1]} \n-Date: {str[2]} \n-Time: {str[3]} \n-Address: {address}");
            Thread.Sleep(4000);
        }
    }
    
    public void GetFullDetails(string address)
    {
        foreach (string item in ShortDetails)
        {   
            string[] str = item.Split("|");
            Console.WriteLine($"-Type event: Lectures \n-Title: {str[0]} \n-Description: {str[1]} \n-Date: {str[2]} \n-Time: {str[3]} \n-Address: {address} \n-Speaker: {str[4]} \n-Event capacity: {str[5]}");
            Thread.Sleep(4000);
        }
    }
}