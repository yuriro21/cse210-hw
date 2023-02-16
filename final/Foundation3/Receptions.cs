using System;
using System.Threading;
public class Receptions : Event
{
    private string _register;
    public Receptions() : base()
    {}

    public Receptions(string _eventTitle, string _description, string _date, string _time, string register) : base(_eventTitle, _description, _date, _time)
    {
        _register = register;
    }

    public override string ToString()
    {
        return string.Format("{0}|{1}|{2}|{3}|{4}", _eventTitle, _description, _date, _time, _register);
    }

    public void GetShortDetails()
    {
        foreach (string item in ShortDetails)
        {   
            string[] str = item.Split("|");
            Console.WriteLine($"-Type event: Reception \n-Title: {str[0]} \n-Date: {str[2]}");
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
            Console.WriteLine($"-Type event: Reception \n-Title: {str[0]} \n-Description: {str[1]} \n-Date: {str[2]} \n-Time: {str[3]} \n-Address: {address} \n-email to reserve: {str[4]}");
            Thread.Sleep(4000);
        }
    }
}