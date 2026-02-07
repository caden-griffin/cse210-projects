using System.Collections.Generic;

public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public double CalculateTotalCost()
    {
        double total = 0;
        foreach (Product product in _products)
        {
            total += product.GetTotalCost();
        }

        double shipping;

        if (_customer.LivesInUSA())
        {
            shipping = 5.00;
        }
        else
        {
            shipping = 35.00;
        }
        return total + shipping;
    }

    public string GetPackingLabel()
    {
        string label = "--- Packing Label ---\n";
        foreach (Product p in _products)
        {
            label += $"Name {p.GetName()} | ID: {p.GetId()}\n";
        }
        return label;
    }

    public string GetShippingLabel()
    {
        return $"--- Shipping Label ---\n{_customer.GetName()}\n{_customer.GetAddressString()}";
    }
}