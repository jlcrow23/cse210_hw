using System.Reflection.Emit;
using System.Data;
using System.Runtime.CompilerServices;
using System;

namespace JournalProgram

{    public class Entry
    {
        public string _date;
        public string _promptText;
        public string _entryText;

        public void Display()
        {
            Console.WriteLine($"Date: {_date}");
            Console.WriteLine($"Prompt: {_promptText}");
            Console.WriteLine($"Entry: {_entryText}");
        }
    }
}