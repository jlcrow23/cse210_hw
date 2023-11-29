using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.Linq;
using System.Threading.Tasks;

public class ListingActivity : Activity
{
    private int _count;
    private static List<string> _prompts = new List<string>();
    public static List<string> _Prompts 
    {
        get
        {
            return _prompts;
        }
        set
        {
            _prompts = value;
        }
    }

    public static void Run()
    {
        Console.Clear();
    }
    public static string GetRandomPrompt()
    {
        _Prompts.Add("Who are the people in your life you appreciate?");
        _Prompts.Add("What are your personal strengths?");
        _Prompts.Add("What are the things you like about yourself?");
        _Prompts.Add("Who do you look up to the most?");

        Random randomPrompt = new Random();
        string prompt = _Prompts[randomPrompt.Next(0, 3)];
        return prompt;
        
    }
    public static void GetListFromUser(int seconds)
    {     
        List<string> list = new List<string>();
        int total = 0;
        var currentTime = DateTime.Now;
        while(DateTime.Now - currentTime < TimeSpan.FromSeconds(_duration))
        {
            string userInput = Console.ReadLine();
            list.Add(userInput);
        } 
        foreach (string item in list)
            {
                if (item != null)
                total ++;
            } 
        Console.WriteLine("**Stop**");
        Thread.Sleep(1000);  
        
        Console.WriteLine($"Amazing! You wrote {total} item(s).");
        Thread.Sleep(5000);
    }
}
