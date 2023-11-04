using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string valueFromUser = Console.ReadLine();

        int x = int.Parse(valueFromUser);

        if (x >= 90)
        {
            Console.WriteLine("You have an A");
            Console.WriteLine("You are passing. Great Job!");
        }
        else if (x >= 80 && x < 90)
        {
            Console.WriteLine("You have a B");
            Console.WriteLine("You are passing. Great Job!");

        }
        else if (x >= 70 && x < 80)
        {
            Console.WriteLine("You have a C");
            Console.WriteLine("You are passing. Great Job!");

        }
        else if (x >= 60 && x < 70)
        {
            Console.WriteLine("You have a D");
            Console.WriteLine("Keeping trying! You can do it!");
        }
        else if (x < 60)
        {
            Console.WriteLine("You have a F");
            Console.WriteLine("Keep trying! You can do it!");
        }
        else{
            Console.WriteLine("Your number is invalid.");
        }
        
    }
}