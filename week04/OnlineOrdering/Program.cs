using System;

class Program
{
    static void Main(string[] args)
    {
        Address address = new Address("123 Main St", "Springfield", "IL", "USA");
        Customer customer = new Customer("John Doe", address);

        Product product = new Product("Laptop", 1, 999.99, 2);
        Product product2 = new Product("Mouse", 2, 25.50, 1);
        Product product3 = new Product("Keyboard", 3, 45.00, 1);
        Product product4 = new Product("Monitor", 4, 199.99, 1);
        Product product5 = new Product("USB Cable", 5, 10.00, 3);
        Product product6 = new Product("HDMI Cable", 6, 15.00, 2);

        Order order = new Order(customer);
        order.AddProduct(product);
        order.AddProduct(product2);
        order.AddProduct(product3);

        Console.WriteLine($"{order.PackingLabel()}");
        Console.WriteLine($"Shipping Label: {order.ShippingLabel()}");
        Console.WriteLine($"Total Cost: ${order.TotalCost()}");

        Console.WriteLine();

        Order order2 = new Order(customer);
        order2.AddProduct(product4);
        order2.AddProduct(product5);
        order2.AddProduct(product6);
        Console.WriteLine($"{order2.PackingLabel()}");
        Console.WriteLine($"Shipping Label: {order2.ShippingLabel()}");
        Console.WriteLine($"Total Cost: ${order2.TotalCost()}");
    }  
}