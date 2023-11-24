
using System.Data;
using System.Collections.Generic;
using System;
using System.Security.Cryptography;
using System.IO;

public class PromptGenerator
{
    public static string[] _prompts = 
    {
        "Name one blessing you are grateful for today.",
        "What is one goal you are working on today?",
        "What superpower would you like to possess and why?",
        "What made you smile today?",
        "What do you want to be remembered for?",
        "What country would like to visit and why?"
    };
        
    public static string GetRandomPrompt()
        {
           var rand = new Random();
           string randomPrompt = _prompts[rand.Next(0, _prompts.Length)];

           return randomPrompt;       
        }

                
}    
                


        

            
