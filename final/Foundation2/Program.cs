using System;
using System.Diagnostics.Contracts;

class Program
{
    static void Main(string[] args)
    {
        // Order order1 = new Order();
        Customer customer = new Customer("Julie Crow");
        Address a1 = new Address("588 W 75 S", "Blackfoot", "ID", "USA");

        //Console.WriteLine(a1.GetShippingLabel());
        

        Product p1 = new Product("Glasses", 1234, 3.99, 3);
        Product p2 = new Product("Dress", 2345, 24.99, 1);

        Order newOrder = new Order();
        newOrder.GetOrder("14569");

        Order._packingList.Add(p1);
        Order._packingList.Add(p2);
        
        Order.Display();
        Console.WriteLine($"Your total with shipping is: {Order.GetTotal()}");

        
        // Console.WriteLine(p1.GetProduct());
        // Console.WriteLine(p2.GetProduct());
    }
}