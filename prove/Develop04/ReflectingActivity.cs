using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class ReflectingActivity : Activity
{
    private static List<string> _prompts = new List<string>();
    private static List<string> _questions = new List<string>();
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
    public static List<string> _Questions 
    {
        get
        {
            return _questions;
        }
        set
        {
            _questions = value;
        }
    }
    public static void Run()
    {
        Console.WriteLine("Ready?");
        
        Thread.Sleep(2000);
        Console.WriteLine(ReflectingActivity.GetRandomPrompt());
        Thread.Sleep(5000);
        Console.WriteLine("Ponder...");

        var currentTime = DateTime.Now;
        while(DateTime.Now - currentTime < TimeSpan.FromSeconds(_duration))
        {
            Console.WriteLine(ReflectingActivity.GetRandomQuestion());
            Thread.Sleep(10000);
            // Console.Clear();
        }
        Thread.Sleep(2000);
    }
    public static string GetRandomPrompt()
    {
        _Prompts.Add("Think of a time when you did something kind for someone else.");
        _Prompts.Add("Think of a time when you did something that was difficult for you.");
        _Prompts.Add("Think of a time when you accomplished something you had worked a long time on.");
        _Prompts.Add("Think of a time when you felt good about yourself.");

        Random randomPrompt = new Random();
        string prompt = _Prompts[randomPrompt.Next(0, 3)];
        return prompt;
    }
    public static string GetRandomQuestion()
    {
        _Questions.Add("Why was this experience meaningful to you?");
        _Questions.Add("Have you ever done anything like this before? Why or why not?");
        _Questions.Add("How did this come about?");
        _Questions.Add("What made this time different from other times?");
        _Questions.Add("What was your favorite thing about this experience?");
        _Questions.Add("What could you learn from this situation that you could apply to other situations?");

        Random randomQuestion = new Random();
        string question = _Questions[randomQuestion.Next(0, 5)];
        return question;
    }
}
