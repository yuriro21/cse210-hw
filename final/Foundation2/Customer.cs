using System;

public class Customer
{
    private string _customerName;
    protected Address _address = new Address();

    public Customer()
    {
    }

    public Customer(string customerName, Address address)
    {
        _customerName = customerName;
        _address = address;
    }

    public string CustomerName { get => _customerName; set => _customerName = value; }
    public Address Address { get => _address; set => _address = value; }

    public bool IsUSA()
    {
        return Address.IsLocal(Address.Contry);
    }
}