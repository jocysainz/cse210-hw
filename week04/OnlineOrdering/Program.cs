using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("127 Sky St", "Conroe", "TX", "USA");
        Customer customer1 = new Customer("Melanie Sainz", address1);

        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Heart Balloons", "H120", 15.00, 5));
        order1.AddProduct(new Product("Necklace", "M226", 25.00, 1));

        Address address2 = new Address("117 Hidalgo", "Obregon", "SN", "Mexico");
        Customer customer2 = new Customer("Laura Grajeda", address2);

        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Monitor", "LG202", 273.89, 1));
        order2.AddProduct(new Product("HDMI Cable", "C111", 10.89, 1));

        DisplayOrder(order1);
        Console.WriteLine();
        DisplayOrder(order2);
    }

    static void DisplayOrder(Order order)
    {
        Console.WriteLine(order.GetPackingLabel());
        Console.WriteLine(order.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order.GetTotalPrice():0.00}");
    }
}