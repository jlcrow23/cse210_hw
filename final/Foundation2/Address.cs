public class Address : Customer
{
    private string _streetAddress;
    private string _city;
    private string _stateProvince;
    private string _country;
    public Address(string CustName, string address, string city, string state, string country) : base(CustName)
    {
        _streetAddress = address;
        _city = city;
        _stateProvince = state;
        _country = country;
    }
    public string GetStreet()
    {
        return _streetAddress;
    }
    public string GetCity()
    {
        return _city;
    }
    public string GetState()
    {
        return _stateProvince;
    }
    public string GetCountry()
    {
        return _country;
    }

    public void IsAddressUS()
    {
        // if _country == ("US" || "USA" || "United States")
        // {

        // }
    }
    public string GetShippingLabel()
    {
        return CustName() + "\n" + _streetAddress + "\n" + _city + ", " + _stateProvince + ", " + _country;
    }
    // public string Display()
    // {
    //    return GetName() + "\n" + GetAddress();
    // }
}