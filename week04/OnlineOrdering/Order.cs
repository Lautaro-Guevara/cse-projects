public class Order
{
    private Customer _customer;
    private List<Product> _products;

    public Order(Customer customer, List<Product> products)
    {
        _customer = customer;
        _products = products;
    }

    public double TotalPrice()
    {
        double totalPrice = 0;
        for (int i = 0; i < _products.Count; i++)
        {
            totalPrice += _products[i].GetTotalCost();
        }

        if (_customer.IsLivingInUSA())
        {
            totalPrice += 5;
        }
        else
        {
            totalPrice += 35;
        }

        return totalPrice;
    }

    public void Label()
    {
        for (int i = 0; i < _products.Count; i++)
        {
            _products[i].DisplayLabel();
        }
    }

    public void Shipping()
    {
        _customer.Display();
    }
}