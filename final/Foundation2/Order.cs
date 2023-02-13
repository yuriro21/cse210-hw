using System;

public class Order 
{
    protected List<Product> productsList = new List<Product>();
    protected List<Customer> customersList = new List<Customer>();
    
    public Order()
    {}

    public List<Product> ProductsList { get => productsList; set => productsList = value; }
    public List<Customer> CustomersList { get => customersList; set => customersList = value; }

    
    public int GetTotalPrice(Address address)
    {
        int _totalPrice = 0;
        foreach (Product item in productsList)
        {
            _totalPrice += item.Price;
        }
        if (address.Contry == "USA")
        {
            _totalPrice += 5;
        }
        else
        {
            _totalPrice += 35;
        }
        return _totalPrice;
    }

    public List<string> PackingLabel()
    {   
        List<string> namesAndID = new List<string>();
        foreach (Product item in productsList)
        {
            string name = item.ProductName;
            int ID = item.ProductID;
            namesAndID.Add($"  Product: {name}, ID: {ID}");
        }
        return namesAndID;
    } 

    public List<string> ShippingLavel()
    {
        List<string> namesAndAddress = new List<string>();
        foreach (Customer item in customersList)
        {
            string name = item.CustomerName;
            string direction = item.Address.ToString();
            namesAndAddress.Add($"   Name: {name} \n{direction}");
        }
        return namesAndAddress;
    }
}