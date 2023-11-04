using System;

class Program
{
    static void Main(string[] args)

    {
        Console.Write("What is the magic number? ");
        string magic = Console.ReadLine();
        int x = int.Parse(magic);

        Console.Write("What is your guess? ");
        string guess = Console.ReadLine();
        int y = int.Parse(guess);

        if (x > y)
        {
            Console.WriteLine("Higher");
        }
        else if (x < y)
        {
            Console.WriteLine("Lower");
        }
        else
        {
            Console.WriteLine("You guessed it!");
        }

    }
}