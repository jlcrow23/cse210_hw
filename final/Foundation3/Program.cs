using System;

class Program
{
    static void Main(string[] args)
    {
        LectureEvent lectureEvent = new LectureEvent("**Lecture**", "LumberJacking... Why is it important?", "George Bunyon", 30, "Lecture series on importance of Lumberjacking", Address.LectureAddress(), "08/03/2010", "12:30pm");
        Console.WriteLine(Event.GetEventType());
        Console.WriteLine("\nStandard Description:");
        Console.WriteLine(lectureEvent.StandardDetails());
        Console.WriteLine("\nShort Description:");
        Console.WriteLine(lectureEvent.ShortDescrip());
        Console.WriteLine("\nLong Description:");
        Console.WriteLine(lectureEvent.FullDetails());

        ReceptionEvent receptionEvent = new ReceptionEvent("**Wedding**", "Mr. and Mrs. Archibald", "208-231-4524", "Come celebrate the wedding of Juliana Short and Michael Archibald", Address.ReceptionAddress(), "12/20/2023", "12:00pm");
        Console.WriteLine(Event.GetEventType());
        Console.WriteLine("\nStandard Description:");
        Console.WriteLine(receptionEvent.StandardDetails());
        Console.WriteLine("\nShort Description:");
        Console.WriteLine(receptionEvent.ShortDescrip());
        Console.WriteLine("\nLong Description:");
        Console.WriteLine(receptionEvent.FullDetails());

        OutdoorEvent outdoorEvent = new OutdoorEvent("**Outdoor Photography**", "Photographing Landscapes", "Sunny, 72 degrees, Clear Skies", "Photographing Landscapes in the afternoon sun", Address.OutdoorAddress(), "06/21/2024", "6:00pm");
        Console.WriteLine(Event.GetEventType());
        Console.WriteLine("\nStandard Description:");
        Console.WriteLine(outdoorEvent.StandardDetails());
        Console.WriteLine("\nShort Description:");
        Console.WriteLine(outdoorEvent.ShortDescrip());
        Console.WriteLine("\nLong Description:");
        Console.WriteLine(outdoorEvent.FullDetails());
    }
}