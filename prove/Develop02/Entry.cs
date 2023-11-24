
using System.Collections.Concurrent;
using System.Runtime.Serialization;
using System.Reflection.Emit;
using System.Data;
using System.Runtime.CompilerServices;
using System;

namespace JournalProgram

{    public class Entry
    {
        public List<string> journalEntries =new List<string>();
        public string _date;
        public string _promptText;
        public string _entryText;

        public static string entryText()
        {
            Console.WriteLine("Enter your answer: ");
            string answer = Console.ReadLine();
            return "";
        }

        public void Display()
        {
            foreach (string entry in journalEntries)
            {
                // Console.WriteLine($"Date: {_date}");
                // Console.WriteLine($"Prompt: {_promptText}");
                // Console.WriteLine($"Entry: {_entryText}");
                Console.WriteLine(entry);
            }
        }
    }
}