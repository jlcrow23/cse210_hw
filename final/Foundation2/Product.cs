using System.Data;
using System.Diagnostics.CodeAnalysis;

public class Product
{
    private static string _productName;
    private static double _productId;
    private static double _price;
    private static double _quantity;
    public Product(string productName, double productID, double price, double quantity)
    {
        _productName = productName;
        _productId = productID;
        _price = price;
        _quantity = quantity;
        
    }
    public static string GetProductName()
    {
        return _productName;
    }
    public static double GetProductId()
    {
        return _productId;
    }
    public static double GetPrice()
    {
        return _price;
    }
    public static double GetQuantity()
    {
        return _quantity;
    }
    public static double GetTotal()
    {
        double sum = 0;
        double total = 0;

        foreach (Product p in Order._packingList)
        {
            
            total += _price * _quantity;
            return total;
            
            // Console.WriteLine("Your total is: ");
        }
        sum += total;
        return sum;

    }

    public void GetProduct()
    {
        Console.WriteLine($"{_productName}\t\t{_productId}\t\t{_price}\t\t{_quantity}");
    }
}