public class Customer
{
    private string _name;
    public string GetName()
    {
        return _name;
    }
    public Customer()
    {
        _name = "Unknown";
    }
    public Customer(string name)
    {
        name = _name;
    }
}