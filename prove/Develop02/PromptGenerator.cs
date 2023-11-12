
using System.Data;
using System.Collections.Generic;
using System;
using System.Security.Cryptography;
using System.IO;

public class PromptGenerator
{
    public List<string> _prompts;
        
    public string GetRandomPrompt()
        {
            Random random = new Random();
            string [] prompt =
            {
                "Name one blessing you are grateful for today",
                "What is one goal you are working on today?",
                "What superpower would you like to possess and why?",
                "What made you smile today?",
                "What do you want to be remembered for?",
                "What country would like to visit and why?"
            };
            // int index = random.Next(prompt.Length);
            // Console.WriteLine($"{prompt[index]}");

            // Console.ReadKey();
            // string Promp = "";
            // PromptGenerator pg = new PromptGenerator();
            // Promp = prompt[Random.Next(Promp.Length)];
            return "";

                 
        }

                
}    
                


        

            
