using System;
public class Order
{
    private static string _total;
    private static List<Address> custAddress = new List<Address>();
    private static List<Product> packingList = new List<Product>();
    
    public static void Display()
    {
        Console.WriteLine ($"{Customer.CustName()}");
        Console.WriteLine($"Here is your order summary: {packingList}");
        Console.WriteLine($"This order will be shipped to this address: {Address.GetShippingLabel()}");

        foreach (Product product in packingList)
        {
            product.GetProduct();
            Console.WriteLine($"Your order total is: {Product.GetTotal()}");
        }

        // foreach (Address address in custAddress)
        // {
        //     address.GetShippingLabel();
        // }
    }
    // public static void GetOrderTotal()
    // {
    //     Product.GetPrice() * GetQuantity();
    // }
}