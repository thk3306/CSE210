using System.Reflection.Metadata.Ecma335;

public class Order
{
    private List<Products> _products = new List<Products>();
    private string _customerName;

    public int TotalCost()
    {
        int total = 0;
        foreach (var product in _products)
        {
            total += product.TotalCost();
        }
        if (_customerAddress == "USA")
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
        string label = $"Packing Label for {_customerName}:\n";
        foreach (var product in _products)
        {
            label += $"{product.id} - ${product.name}\n";
        }
        return label;
    }

    public string ShippingLabel()
    {
        return $"{_customerName} - {_customerAddress}";
    }
}
