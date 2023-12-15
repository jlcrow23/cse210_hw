using System;
public class Order
{
    private string _orderNumber;
    private static double _total;
    public static List<Product> _packingList=new List<Product>(); // I could not figure out how to make this list private and have it add items
    public void AddItems()
    {
        foreach (Product p in _packingList)
        {
            p.GetProduct();
        }
    }
    public static void Display()
    {
        Console.WriteLine ($"Hello, {Customer.CustName()}");
        Console.WriteLine($"You have this many items: {Product.GetQuantity()}");
        Console.WriteLine($"This order will be shipped to this address: {Address.GetShippingLabel()}");
        Console.WriteLine($"\nOrder Summary:\nProduct\t\tProductId\tPrice\t  Quantity\n");
        
        foreach (Product p in _packingList)
        {
            p.GetProduct();
        }
        // Console.WriteLine(Order._packingList);
        Console.WriteLine($"Your order total is: {Product.GetTotal()}");

        
    }
    public void GetOrder(string orderNum)
    {
        _orderNumber = orderNum;

    }
    public static double GetTotal()
    {
        _total = Product.GetTotal() + 34.95;
        return _total;
        
        
    }

    // public static void GetOrderTotal()
    // {
    //     int _total = 0;
    //     foreach (int quantity in packingList)
    //     {
    //         _total += Product.
    //     }
    //     Product.GetPrice() * GetQuantity();
    // }
}