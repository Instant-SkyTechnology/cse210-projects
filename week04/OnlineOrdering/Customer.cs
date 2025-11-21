public class Customer
{
    private string _name;
    private Address _address;

    // CONSTRUCTOR
    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    // GETTERS AND SETTERS
    public string GetName()
    {
        return _name;
    }
    public void SetName(string name)
    {
        _name = name;
    }

    public Address GetAddress()
    {
        return _address;
    }

    public bool LivesInUSA()
    {
        return _address.IsUSA();
    }
}