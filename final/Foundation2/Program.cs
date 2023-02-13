using System;

class Program
{
    static void Main(string[] args)
    {   
        //Creating order 1
        Address address1 = new Address("Calle 3 Carrera 6", "Pirineos", "Tachira", "Venezuela");
        Customer customer1 = new Customer("Edisson Ruiz", address1);
        Product product1Customer1 = new Product("Laptop", 4090, 2000, 2);
        Product product2Customer1 = new Product("Mouse", 7000, 50, 2);
        Product product3Customer1 = new Product("Keyboard", 8050, 80, 2);
        Order order1 = new Order();
        
        //Creating a packing label for order 1
        order1.ProductsList.Add(product1Customer1);
        order1.ProductsList.Add(product2Customer1);
        order1.ProductsList.Add(product3Customer1);
        List<string> pakingLabel = order1.PackingLabel();
        Console.WriteLine("\nPacking Label Order 1: ");
        foreach(string i in pakingLabel)
        {
            Console.WriteLine(i);
        }

        //Creating a shipping label for order 1
        order1.CustomersList.Add(customer1);
        Console.WriteLine("\nShipping Label Order 1: ");
        List<string> shippingLabel = order1.ShippingLavel();
        foreach (string i in shippingLabel)
        {
            Console.WriteLine(i);
        }

        //Creating the total price for order 1
        int totalPrice = order1.GetTotalPrice(customer1.Address);
        Console.WriteLine("\nThe total price for order 1 is: ");
        Console.WriteLine($"${totalPrice}");


        //Creating order 2
        Address address2 = new Address("700N 500w", "Provo", "Utah", "USA");
        Customer customer2 = new Customer("Rosi Berrios", address2);
        Product product1Customer2 = new Product("AirPods", 1200, 250, 3);
        Product product2Customer2 = new Product("Apple Watch", 7000, 800, 2);
        Product product3Customer2 = new Product("Apple Tv 4k", 3030, 130, 4);
        Order order2 = new Order();
        
        //Creating a packing label for order 2
        order2.ProductsList.Add(product1Customer2);
        order2.ProductsList.Add(product2Customer2);
        order2.ProductsList.Add(product3Customer2);
        List<string> pakingLabel2 = order2.PackingLabel();
        Console.WriteLine("\nPacking Label Order 2: ");
        foreach(string i in pakingLabel2)
        {
            Console.WriteLine(i);
        }

        //Creating a shipping label for order 2
        order2.CustomersList.Add(customer2);
        Console.WriteLine("\nShipping Label Order 2: ");
        List<string> shippingLabel2 = order2.ShippingLavel();
        foreach (string i in shippingLabel2)
        {
            Console.WriteLine(i);
        }

        //Creating the total price for order 2
        int totalPrice2 = order2.GetTotalPrice(customer2.Address);
        Console.WriteLine("\nThe total price for order 2 is: ");
        Console.WriteLine($"${totalPrice2}");
    }
}