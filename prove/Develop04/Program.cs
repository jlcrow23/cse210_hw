using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("\n*** Welcome, please choose from the following menu: ***\n");
            Console.WriteLine("1: Breathing Activity");
            Console.WriteLine("2: Listing Activity");
            Console.WriteLine("3: Reflecting Activity");
            Console.WriteLine("4: Picture This");
            Console.WriteLine("5: Quit\n");
            Console.Write("Your choice: ");
            
            int userSelection = int.Parse(Console.ReadLine());

            if (userSelection == 1)
            {
                BreathingActivity.DisplayStartMessage("Breathing Activity", "This activity will help you slow down. Just breathe...");
                BreathingActivity.ShowSpinner();
                BreathingActivity.Run();
                BreathingActivity.DisplayEndMessage();
            }
            if (userSelection == 2)
            {
                ListingActivity.DisplayStartMessage("Listing Activity", "This activity will help you think of what is truely important. Type the first thing that comes to mind and press enter.");
                ListingActivity.ShowSpinner();
                Console.WriteLine(ListingActivity.GetRandomPrompt());
                Thread.Sleep(5000);
                ListingActivity.GetListFromUser(5);
                ListingActivity.DisplayEndMessage();
            }
            if (userSelection == 3)
            {
                ReflectingActivity.DisplayStartMessage("Reflecting Activity", "This activity will help you reflect on times in your life when you have had strength and resilience. You have great power. See where else you can use it.");
                ReflectingActivity.ShowSpinner();
                ReflectingActivity.Run();
                ReflectingActivity.DisplayEndMessage();
            }
            if (userSelection == 4) // stretch challange
            {
                PictureActivity.DisplayStartMessage("Picture This", "This activity will help you paint a picture in your mind of a memorable day. It will help you remember details.");
                PictureActivity.ShowSpinner();
                PictureActivity.Run();
                PictureActivity.DisplayEndMessage();
            }
            else if (userSelection == 5)
            {
                Thread.Sleep(1000);
                Console.WriteLine("\nHave a wonderful day! Come back soon!\n");
                Thread.Sleep(1000);
                break;
            }
        }
    }
}