using System;
using System.Threading;
public class Outdoor : Event
{
    private string _weather;
    public Outdoor() : base()
    {}

    public Outdoor(string _eventTitle, string _description, string _date, string _time, string weather) : base(_eventTitle, _description, _date, _time)
    {
        _weather = weather;
    }

    public override string ToString()
    {
        return string.Format("{0}|{1}|{2}|{3}|{4}", _eventTitle, _description, _date, _time, _weather);
    }
    public void GetShortDetails()
    {
        foreach (string item in ShortDetails)
        {   
            string[] str = item.Split("|");
            Console.WriteLine($"-Type event: Outdoor \n-Title: {str[0]} \n-Date: {str[2]}");
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
            Console.WriteLine($"-Type event: Outdoor \n-Title: {str[0]} \n-Description: {str[1]} \n-Date: {str[2]} \n-Time: {str[3]} \n-Address: {address} \n-Weather: {str[4]}");
            Thread.Sleep(4000);
        }
    }
}