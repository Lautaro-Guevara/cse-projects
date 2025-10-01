public class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public bool IsLivingInUSA()
    {
        return _address.IsInUSA();
    }

    public void Display()
    {
        Console.WriteLine($"{_name} - {_address.Display()}");
    }
}