using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();

        string userName = PromptUserName();
        int UserNumber = PromptUserNumber();

        int squareNumber = squareOfNumber(UserNumber);

        DisplayResults(userName, squareNumber);
    }
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();

        return name;
    }
    static int PromptUserNumber()
    {
        Console.Write("What is your favorite number? ");
        int number = int.Parse(Console.ReadLine());

        return number;
    }
    static int squareOfNumber(int number)
    {
        int square = number * number;
        return square;
    }
    static void DisplayResults(string name, int square)
    {
        Console.WriteLine($"{name}, the square of your favorite number is {square}");
    }
}