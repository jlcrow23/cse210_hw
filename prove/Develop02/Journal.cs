
using System.ComponentModel.DataAnnotations;
using System;

namespace JournalProgram

{
    public class Journal
    {
        public List<Entry> _entries = new List<Entry>();
        public void AddEntry(Entry newEntry)
        {
            
        }
        public void DisplayAll()
        {
            Console.WriteLine($"Saved Entries: ");

            foreach (Entry entry in _entries)
            {
                entry.Display();
            }
        }
        public void SaveToFile(List<Entry> journalEntries)
        {
            Console.WriteLine("Saving to File...");
            string filename = "journalEntries.txt";

            using (StreamWriter outputFile = new StreamWriter(filename))
            {
                foreach (Entry e in journalEntries)
                {
                    outputFile.WriteLine($"{e._date}~~{e._promptText}~~{e._entryText}");
                }
            }

            Console.WriteLine("Entry Saved.");
        }
        public void LoadFromFile(string file)
        {
            
        }

        
    }
}