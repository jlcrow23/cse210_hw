public class Address
{
    private static string _streetAddress;
    private static string _city;
    private static string _stateProvince;
    private static string _country;
    public Address(string address, string city, string state, string country)
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

    public static void IsAddressUS()
    {
        // if _country == ("US" || "USA" || "United States")
        // {

        // }
    }
    public static string GetShippingLabel()
    {
        return "\n" + Customer.CustName() + "\n" + _streetAddress + "\n" + _city + ", " + _stateProvince + ", " + _country;
    }
    // public string Display()
    // {
    //    return GetName() + "\n" + GetAddress();
    // }
}