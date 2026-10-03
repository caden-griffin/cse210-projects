using System;

namespace OnlineOrdering;

class Program
{
    static void Main(string[] args)
    {

        Address address1 = new Address("123 Main St", "Salt Lake City", "UT", "USA");
        Customer customer1 = new Customer("Caden Griffin", address1);
        Order order1 = new Order(customer1);

        order1.AddProduct(new Product("Wireless Mouse", "M100", 25.99, 1));
        order1.AddProduct(new Product("Mechanical Keyboard", "K400", 79.99, 1));
        order1.AddProduct(new Product("Mouse Pad", "P50", 12.50, 2));

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order1.GetTotalCost():0.00}");
        Console.WriteLine(new string('=', 40));
        Console.WriteLine();

        Address address2 = new Address("456 Queen St", "Toronto", "ON", "Canada");
        Customer customer2 = new Customer("Alex Smith", address2);
        Order order2 = new Order(customer2);

        order2.AddProduct(new Product("USB-C Hub", "H200", 34.99, 1));
        order2.AddProduct(new Product("HDMI Cable", "C10", 15.00, 2));

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order2.GetTotalCost():0.00}");
    }
}