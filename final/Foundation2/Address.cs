public class Address : Customer
{
    private string _streetAddress;
    private string _city;
    private string _stateProvince;
    private bool _country = true;
    public Address(string name, string address, string city, string state, string country)
    {
        name = GetName();
        address = _streetAddress;
        city = _city;
        state = _stateProvince;
        country = _country;
    }
    public string GetAddress()
    {
        return $"{_streetAddress}\n{_city}, {_stateProvince}, {_country}";
    }
    public void Display()
    {
        Console.WriteLine($"{GetName}\n{GetAddress}");
    }
}