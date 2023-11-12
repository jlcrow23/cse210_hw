
using System;

namespace JournalProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Type the number for the option you wish to do:");
                Console.WriteLine("1: Write a new entry");
                Console.WriteLine("2: Display current entry");
                Console.WriteLine("3: Save entry");
                Console.WriteLine("4: Display all entries");
                Console.WriteLine("5: Quit");

                int userChoice = int.Parse(Console.ReadLine());

                Entry anEntry = new Entry();
                Journal journals = new Journal();
                
                if (userChoice == 1)
                {
                    // 1 pressed
                    Entry entry1 = new Entry();
                    entry1._date = DateTime.Today.ToString("MM/dd/yyy");
                    entry1._promptText = "Some text here";
                    PromptGenerator prompt1 = new PromptGenerator();
                    prompt1.GetRandomPrompt();
                    entry1._entryText = "Some text here";
                    Console.WriteLine($"{entry1._date}");
                    Console.WriteLine($"{entry1._promptText}");
                    Console.WriteLine($"{entry1._entryText}");
                }

                if (userChoice == 2)
                {
                    // 2 pressed
                    anEntry.Display();

                }

                if (userChoice == 3)
                {
                    // 3 pressed
                    Console.WriteLine("Save File");

                }

                if (userChoice == 4)
                {
                    // 4 pressed
                    Journal theJournal = new Journal();

                    theJournal._entries.Add(anEntry);
                    
                    theJournal.DisplayAll();

                }
                else if (userChoice == 5)
                {
                    break;
                }

            }
            
            

            Console.WriteLine("See you next time!");          
        }

    }

}
    