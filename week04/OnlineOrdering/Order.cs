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

    public string GetPackingLabel()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine("===== YOUR ORDER =====");

        foreach (Product p in _products)
        {
            sb.AppendLine($"{p.GetName()} (ID: {p.GetProductId()})");
        }

        return sb.ToString();
    }

    public string GetShippingLabel()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine("=== SHIPPING ADDRESS ===");
        sb.AppendLine(_customer.GetName());
        sb.AppendLine(_customer.GetAddress().GetFullAddress());

        return sb.ToString();
    }
}