using System;
using System.IO; // needed to write csv

class Program
{
    static void Main(string[] args)
    {
        // Add people with the following code

            // Person p1 = new Person();
            // p1._firstName ="Mary";
            // p1._lastName = "Smith";
            // p1._age = 25;

            // Person p2 = new Person();
            // p2._firstName ="John";
            // p2._lastName ="Watkins";
            // p2._age = 30;

            // List<Person> people = new List<Person>();
            // people.Add(p1);
            // people.Add(p2);

            // foreach (Person p in people)
            // {
            //     Console.WriteLine(p._firstName);
            // }

            // SaveToFile(people);

        // The following code reads from a file
        List<Person> newPeople = ReadFromFile();
        foreach (Person p in newPeople)
        {
            Console.WriteLine(p._lastName);
        }
    }

    // Save to File Function
    public static void SaveToFile(List<Person> people)
    {
        Console.WriteLine("Saving to File...");
        string filename = "people.txt";

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Person p in people)
            {
                outputFile.WriteLine($"{p._firstName}~~{p._lastName}~~{p._age}");
            }
        }
    }

    // Read from File Function
    public static List<Person> ReadFromFile()
    {
        Console.WriteLine("Reading list from file...");
        List<Person> people = new List<Person>();
        string filename = "people.txt";

        string [] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            // Console.WriteLine(line);
            // line will have something like this
            string[] parts = line.Split("~~");

            Person newPerson = new Person();
            newPerson._firstName = parts[0];
            newPerson._lastName = parts[1];
            newPerson._age = int.Parse(parts[2]);

            people.Add(newPerson);
        }
        return people;
    }
}