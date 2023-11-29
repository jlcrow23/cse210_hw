using System.Runtime.Serialization;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Net;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

public class Activity
{
    protected static string _name;
    protected static string _description;
    protected static int _duration;
   public string GetName()
   {
    return _name;
   }
   public void SetName(string name)
   {
        _name = name;
   }
    public string GetDescription()
    {
        return _description;
    }
    public static void SetDescription(string description)
    {
        _description = description;
    }
    public int GetDuration()
    {
        return _duration;
    }
    public static void SetDuration(int duration)
    {
        _duration = duration;
    }
    public static void DisplayStartMessage(string name, string description)
    {
        Console.Clear();
        _name = name;
        _description = description;
        Console.WriteLine($"Welcome to the {name}");
        Console.WriteLine($"{description}");
        Console.WriteLine("How many seconds would you like to perform this activity?");
        int seconds = int.Parse(Console.ReadLine());
        Activity.SetDuration(seconds);
    }
    public static void DisplayEndMessage()
    {
        Thread.Sleep(1000);
        Console.WriteLine("Great Job! Remember; You are a child of a loving Father in Heaven!\n");
        Thread.Sleep(3000);
    }
    public static void ShowSpinner()
    {
        Console.Clear();
        var currentTime = DateTime.Now;
        while(DateTime.Now - currentTime < TimeSpan.FromSeconds(3))
        {
            Console.Write("|");
            Thread.Sleep(500);
            Console.Write("\b \b"); // Erase the + character
            Console.Write("-"); // Replace it with the - character
            Thread.Sleep(500);
            Console.Write("\b\b");
        }
        Console.Clear();
            
    }
    public static void ShowCountdown(int seconds)
    {
        for(int i = 0; i < seconds; i++)
        {
            // Thread.Sleep(1000);
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
    public void AcitvityPause()
    {
        Thread.Sleep(1000);
    }
}
