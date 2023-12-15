public class Customer
{
    private static string _name;
    public Customer(string CustName)
    {
        _name = CustName;
    }
    public string GetName()
    {
        return _name;
    }
    public static string CustName()
    {
        return _name;
    }
    
   
}