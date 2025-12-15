using System.Collections.Generic;
using System.Text;

public class Order
{
    private Customer _customer;
    private List<Product> _products = new List<Product>();

    // CONSTRUCTOR
    public Order(Customer customer)
    {
        _customer = customer;
    }

    // METHODS
    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public double GetTotalPrice()
    {
        double productTotal = 0;

        foreach (Product p in _products)
        {
            productTotal += p.GetTotalCost();
        }

        // Shipping cost
        double shipping = _customer.LivesInUSA() ? 5 : 35;

        return productTotal + shipping;
    }

    // public string GetPackingLabel()
    public void GetPackingLabel()
    {
        // StringBuilder sb = new StringBuilder();
        // sb.AppendLine("===== YOUR ORDER =====");

        // foreach (Product p in _products)
        // {
        //     sb.AppendLine($"{p.GetName()} (ID: {p.GetProductId()})");
        // }

        // return sb.ToString();
        
        Console.WriteLine("===== YOUR ORDER =====");

        foreach (Product p in _products)
        {
            Console.WriteLine($"{p.GetName()} (ID: {p.GetProductId()})");
        }

    }

    // public string GetShippingLabel()
    public void GetShippingLabel()
    {
        // StringBuilder sb = new StringBuilder();
        // sb.AppendLine("=== SHIPPING ADDRESS ===");
        // sb.AppendLine(_customer.GetName());
        // sb.AppendLine(_customer.GetAddress().GetFullAddress());

        // return sb.ToString();

        Console.WriteLine("=== SHIPPING ADDRESS ===");
        Console.WriteLine(_customer.GetName());
        Console.WriteLine(_customer.GetAddress().GetFullAddress());

    }
}