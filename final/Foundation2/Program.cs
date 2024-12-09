using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address
        {
            StreetAddress = "123 Main St",
            City = "Anytown",
            StateProvince = "CA",
            Country = "USA"
        };

        Customer customer1 = new Customer
        {
            Name = "John Doe",
            Address = address1
        };

        Product product1 = new Product
        {
            Name = "Laptop",
            ProductId = "TECH001",
            PricePerUnit = 1000.00m,
            Quantity = 1
        };

        Product product2 = new Product
        {
            Name = "Mouse",
            ProductId = "TECH002",
            PricePerUnit = 25.00m,
            Quantity = 2
        };

        Order order1 = new Order();
        order1.Customer = customer1;
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Address address2 = new Address
        {
            StreetAddress = "456 Global Ave",
            City = "Toronto",
            StateProvince = "ON",
            Country = "Canada"
        };

        Customer customer2 = new Customer
        {
            Name = "Jane Smith",
            Address = address2
        };

        Product product3 = new Product
        {
            Name = "Headphones",
            ProductId = "AUDIO001",
            PricePerUnit = 150.00m,
            Quantity = 1
        };

        Order order2 = new Order();
        order2.Customer = customer2;
        order2.AddProduct(product3);

        Console.WriteLine("Order 1 Packing Label:");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine("\nOrder 1 Shipping Label:");
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"\nOrder 1 Total Price: ${order1.GetTotalPrice():F2}");

        Console.WriteLine("\n-------------------\n");

        Console.WriteLine("Order 2 Packing Label:");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine("\nOrder 2 Shipping Label:");
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"\nOrder 2 Total Price: ${order2.GetTotalPrice():F2}");
    }
}