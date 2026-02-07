using System;

class Program
{
    static void Main(string[] args)
    {
        Address addr1 = new Address("229 Vibely Vacuum", "Spanish Fork", "UT", "USA");
        Customer cust1 = new Customer("Lauren Smith", addr1);
        Order order1 = new Order(cust1);
        order1.AddProduct(new Product("Plastic Cup", "C001", 0.50, 50));
        order1.AddProduct(new Product("Computer", "C002", 2500.00, 3));

        Address addr2 = new Address("382 Frigid Freezer", "Yakutsk", "Siberia", "Russia");
        Customer cust2 = new Customer("Vlad Vlad", addr2);
        Order order2 = new Order(cust2);
        order2.AddProduct(new Product("Tiger Skin Rug", "T001", 63.83, 1));
        order2.AddProduct(new Product("Paperclip", "P001", 0.01, 1));
        order2.AddProduct(new Product("Rubber Band", "R001", 0.02, 100000));

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Order Cost: ${order1.CalculateTotalCost():0.00}");
        Console.WriteLine();

        Console.WriteLine("---------------------------------");

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Order Cost: ${order2.CalculateTotalCost():0.00}");
        Console.WriteLine();
    }
}