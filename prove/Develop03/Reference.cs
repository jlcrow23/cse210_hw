
using System;
public class Reference // Keeps track of book, chapter, verse information
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;

    // public string GetDisplayText()
    // {
    //     return "Hi!";
    // }

    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        Console.Write($"{book} {chapter}:{verse} ");
        
    }

    public Reference(string book, int chapter, int verse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = endVerse;
        Console.Write($"{book} {chapter}:{verse}-{endVerse} ");
        
    }
    public void GetDisplayText()
    {
        Console.WriteLine($"{_book} {_chapter}:{_verse}-{_endVerse}");

    }

}