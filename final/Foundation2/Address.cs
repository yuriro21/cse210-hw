using System;

public class Address
{
    private string _street, _city, _state, _contry;

    public Address()
    {}

    public string Street { get => _street; set => _street = value; }
    public string City { get => _city; set => _city = value; }
    public string State { get => _state; set => _state = value; }
    public string Contry { get => _contry; set => _contry = value; }

    public bool IsLocal(string address)
    {
        if (address == "USA" || address == "EEUU" || address == "United States")
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public override string ToString()
    {
        return string.Format(" Street: {0} \n City: {1} \n State: {2} \n Contry: {3}", _street, _city, _state, _contry);
    }
}