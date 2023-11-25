using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

public class Activity
{
    private static string _name;
    private static string _description;
    private static int _duration;
    // public Activity(string name, string description)
    // {
    //     _name = name;
    //     _description = description;
    // }
    
    public static void DisplayStartMessage()
    {
        Console.WriteLine($"Welcome to the {_name}");
        Console.WriteLine("How many seconds would you like to perform this activity?");
        int seconds = int.Parse(Console.ReadLine());


        
    }
    public static void DisplayEndMessage()
    {
        Console.WriteLine("Great Job! Remember, you are a child of a loving Father in Heaven!");
    }
    public static void ShowSpinner(int seconds)
    {
        _duration = seconds;
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(5);

        Thread.Sleep(100);

        DateTime currentTime = DateTime.Now;
        if (currentTime < futureTime)
        {
            Console.Write("|");
            Thread.Sleep(500);
            Console.Write("\b \b"); // Erase the + character
            Console.Write("-"); // Replace it with the - character
            Thread.Sleep(500);
            Console.Write("\b\b");
            Console.Write("|");
            Thread.Sleep(500);
            Console.Write("\b \b"); // Erase the + character
            Console.Write("-"); // Replace it with the - character
            Thread.Sleep(500);
            Console.Write("\b\b");
            Console.Write("|");
            Thread.Sleep(500);
            Console.Write("\b \b"); // Erase the + character
            Console.Write("-"); // Replace it with the - character
            Thread.Sleep(500);
            Console.Write("\b\b");
            
        }
            
    }
    public void ShowCountdown(int seconds)
    {

    }
}
