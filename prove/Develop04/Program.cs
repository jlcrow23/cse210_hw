using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Welcome, please chose from the following menu:");
            Console.WriteLine("1: Breathing Activity");
            Console.WriteLine("2: Listing Activity");
            Console.WriteLine("3: Reflecting Activity");
            Console.WriteLine("4: Quit");
            
            int userSelection = int.Parse(Console.ReadLine());

            if (userSelection == 1)
            {
                BreathingActivity.DisplayStartMessage();
                // int seconds = int.Parse(Console.ReadLine());
                BreathingActivity.ShowSpinner(10);
            }
            if (userSelection == 2)
            {

            }
            if (userSelection == 3)
            {

            }
            else if (userSelection == 4)
            {
                Activity.DisplayEndMessage();
                break;
            }
        }
    }
}