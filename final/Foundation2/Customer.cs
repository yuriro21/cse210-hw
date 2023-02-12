using System;

public class Customer
{
    private string _customerName;
    private Address _address;

    public Customer()
    {
        Address = new Address();
    }

    public string CustomerName { get => _customerName; set => _customerName = value; }
    public Address Address { get => _address; set => _address = value; }

    public bool IsUSA()
    {
        return Address.IsLocal(Address.Contry);
    }
}