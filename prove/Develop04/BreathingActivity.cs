using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class BreathingActivity : Activity
{
    public static void Run()
    {
        Console.WriteLine("Ready?");
        
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        Thread.Sleep(2000);
        
        var currentTime = DateTime.Now;
        while(DateTime.Now - currentTime < TimeSpan.FromSeconds(_duration))
        {
            Console.Write("Breathe in...");
            Thread.Sleep(500);
            Console.Write("1");
            Thread.Sleep(1000);
            Console.Write("\b \b");
            Console.Write("2");
            Thread.Sleep(1000);
            Console.Write("\b \b");
            Console.Write("3");
            Thread.Sleep(1000);
            Console.Write("\b \b");
            Console.WriteLine("");
            Thread.Sleep(500); 
            Console.Write("Breathe out...");
            Thread.Sleep(500);
            Console.Write("1");
            Thread.Sleep(1000);
            Console.Write("\b \b");
            Console.Write("2");
            Thread.Sleep(1000);
            Console.Write("\b \b");
            Console.Write("3");
            Thread.Sleep(1000);
            Console.Write("\b \b");
            Console.WriteLine("");
            Thread.Sleep(500); 
        }
       

        
    }
}
