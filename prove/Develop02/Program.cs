

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
                // Journal journals = new Journal();
                List<string> journalEntries = new List<string>();
                
                if (userChoice == 1)
                {
                    // 1 pressed
                    // Entry anEntry = new Entry();
                    // anEntry1._date = DateTime.Today.ToString("MM/dd/yyyy");
                    // anEntry1._promptText = PromptGenerator.GetRandomPrompt();
                    // anEntry1._entryText = Entry.entryText();
                    Console.WriteLine(DateTime.Today.ToString("MM/dd/yyyy"));
                    Console.WriteLine(PromptGenerator.GetRandomPrompt());
                    Console.WriteLine(Entry.entryText());
                    string Entry1 = Console.ReadLine();
                    journalEntries.Add(Entry1);
                    // Console.WriteLine($"{_date}\n{_promptText}\n{_entryText}");
                }

                if (userChoice == 2)
                {
                    // 2 pressed
                    anEntry.Display();

                }

                if (userChoice == 3)
                {
                    // 3 pressed
                    // journalEntries.Add(anEntry1);
                    Console.WriteLine("Save File");

                }

                if (userChoice == 4)
                {
                    // 4 pressed
                    Journal theJournal = new Journal();

                    theJournal._entries.Add(anEntry);
                    
                    theJournal.DisplayAll();
                    // Journal.DisplayAll(journalEntries);

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
    