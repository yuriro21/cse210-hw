using System;

public class Product
{
    private string _productName;
    private int _productID, _price, _quantity;

    public Product()
    {
    }

    public Product(string productName, int productID, int price, int quantity)
    {
        _productName = productName;
        _productID = productID;
        _price = price * quantity;
        _quantity = quantity;
    }

    public string ProductName { get => _productName; set => _productName = value; }
    public int ProductID { get => _productID; set => _productID = value; }
    public int Price { get => _price; set => _price = value; }
    public int Quantity { get => _quantity; set => _quantity = value; }
}