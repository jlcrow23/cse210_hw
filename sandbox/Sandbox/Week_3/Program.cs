using System.Reflection.Metadata.Ecma335;
using System;

namespace Week_3
{
    class Program
    {
        static void Main(string[] args)
        {
        
        Account savings = new Account();

        // vsavings.balance - 50; // won't work if private
        // savings.SetBalance(50); // accesses pivate area but not the best; exposes balance

        int money = savings.GetBalance(); // accesses private area using .Get or .Set

        savings.Deposit(50); // puts it back in class so nothing gets exposed

        // break

        Person p = new Person();
        p.SetFirstName("Peter");

        Console.WriteLine(p.GetFirstName());

        Person p1 = new Person(); // Don't pass any information to get default
        Person p2 = new Person("Jane", "Doe"); // pass the first and last name
        Person p3 = new Person("Marshal.", "Jane", "Doe"); // pass all three variables

        Console.WriteLine("");
        }
    }

    

    
}