using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter number: ");
        string valueFromUser = Console.ReadLine();

        int x = int.Parse(valueFromUser);

        if (x >= 90)
        {
            Console.WriteLine("You have an A");
        }
        else if (x >= 80 && x < 90)
        {
            Console.WriteLine("You have a B");
        }
        else if (x >= 70 && x < 80)
        {
            Console.WriteLine("You have a C");
        }
        else if (x >= 60 && x < 70)
        {
            Console.WriteLine("You have a D");
        }
        else if (x < 60)
        {
            Console.WriteLine("You have a F");
        }
        else{
            Console.WriteLine("Your number is invalid.");
        }
        
    }
}