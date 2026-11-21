using System;


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
        double subtotal = 0;

        foreach (Product product in _products)
        {
            subtotal += product.GetTotalCost();
        }
        
        double shippingCost = _customer.LivesInUSA() ? 5.00 : 35.00;
        return subtotal + shippingCost;
    }

    public string GetPackingLabel()
    {
        string label = "PACKING LABEL: \n";

        foreach(Product product in _products)
        {
            label += $"- {product.GetPackingInfo()}\n";
        }
        
        return label.TrimEnd();
    }

    public string GetShippingLabel()
    {
        return $"SHIPPING LABEL: \n{_customer.GetName()}\n{_customer.GetAddress().GetFullAddress()}";
    }
}