using System.Reflection.Metadata.Ecma335;

public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;
    public Order(Customer customer)
    {
        _customer = customer;
    }
    public double TotalCost()
    {
        double total = 0;
        foreach (var product in _products)
        {
            total += product.TotalCost();
        }
        if (_customer.LivesInUSA())
        {
            total += 5;
        }
        else
        {
            total += 35;
        }
        return total;
    }
    public string PackingLabel()
    {
        string label = $"Packing Label for {_customer.GetName}:\n";
        foreach (var product in _products)
        {
            label += $"{product.GetId} - ${product.GetName}\n";
        }
        return label;
    }

    public string ShippingLabel()
    {
        return $"{_customer.GetName} - {_customer.GetAddress()}";
    }
}
