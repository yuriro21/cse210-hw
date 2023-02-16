using System;
using System.Threading;
public class EventAddress : Event
{
    private string _address;
    public EventAddress() : base()
    {}

    public EventAddress(string address) : base()
    {
        _address = address;
    }

    public string Address { get => _address; set => _address = value; }
}