using System;
public class Order
{
    private static string _total;
    public static List<Product> packingList = new List<Product>();
    
    public static void Display()
    {
        Console.WriteLine ($"{Customer.CustName()}");
        Console.WriteLine($"You have this many items: {packingList.Count}");
        Console.WriteLine($"This order will be shipped to this address: {Address.GetShippingLabel()}");

        foreach (Product product in packingList)
        {
            product.GetProduct();
        }
        Console.WriteLine($"Your order total is: {Product.GetTotal()}");

        
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