using System.Data;

public class Product
{
    private string _productName;
    private double _productId;
    private double _price;
    private double _quantity;
    public Product(string productName, double productID, double price, double quantity)
    {
        _productName = productName;
        _productId = productID;
        _price = price;
        _quantity = quantity;
        
    }
    public string GetProductName()
    {
        return _productName;
    }
    public double GetProductId()
    {
        return _productId;
    }
    public double GetPrice()
    {
        return _price;
    }
    public double GetQuantity()
    {
        return _quantity;
    }

    public string GetProduct()
    {
        return _productName + "\t\t" + _productId + "\t\t" + _price + "\t\t" + _quantity;
    }
}