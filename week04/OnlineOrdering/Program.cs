using System;

class Program
{
    static void Main(string[] args)
    {
        // Lives outside of USA
        Address a1 = new Address("134 Deschamps Av", "Ottawa", "ON", "Canada");
        Customer c1 = new Customer("John Kalala", a1);
        Order o1 = new Order(c1);

        o1.AddProduct(new Product("Laptop", "T16", 1999.99, 1));
        o1.AddProduct(new Product("Mouse", "MSE200", 25.50, 2));

        // Lives outside of USA
        Address a2 = new Address("123 Maple Street", "Salt Lake City", "UT", "USA");
        Customer c2 = new Customer("Wilson Ebualontin", a2);
        Order o2 = new Order(c2);

        // Adding new products to the order
        o2.AddProduct(new Product("Smartphone", "SPH101", 799.99, 1));
        o2.AddProduct(new Product("Wireless Charger", "WCH202", 29.99, 2));
        o2.AddProduct(new Product("Headphones", "HP303", 89.99, 1));

        // DISPLAY ORDER 1
        Console.WriteLine(o1.GetPackingLabel());
        Console.WriteLine(o1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${o1.GetTotalPrice():0.00}");
        Console.WriteLine();

        // DISPLAY ORDER 2
        Console.WriteLine(o2.GetPackingLabel());
        Console.WriteLine(o2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${o2.GetTotalPrice():0.00}");
    }
}
