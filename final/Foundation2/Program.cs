using System;
using System.Diagnostics.Contracts;

class Program
{
    static void Main(string[] args)
    {
        Address a1 = new Address("Julie Crowther", "588 W 75 S", "Blackfoot", "ID", "USA");

        Console.WriteLine(a1.GetShippingLabel());

        Product p1 = new Product("Glasses", 1234, 3.99, 3);
        Product p2 = new Product("Dress", 2345, 24.99, 1);

        Console.WriteLine("Product\t\tProductId\tPrice\t  Quantity\n");
        Console.WriteLine(p1.GetProduct());
        Console.WriteLine(p2.GetProduct());
    }
}