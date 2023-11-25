
using System;
using System.Runtime.CompilerServices;
public class Scripture // Keeps track of both the reference and the text of the scripture
                       // Can hide words and get rendered display of the text 
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();
    

    public Scripture()
    {
        Console.WriteLine("If any of you lack wisdom,\nlet him ask of God,\nthat giveth to all men liberally,\nand upbraideth not; \nand it shall be given him.");
    }
    public void HideRandomWords(Word numberToHide)
    {
        foreach (Word word  in _words)
        {
           _words.Add(numberToHide); 
        }
        
    }
    public void Display()
    {
        Console.WriteLine("Scripture Reference: ");
        Console.WriteLine("Scripture Text: ");
    }
    public bool IsCompletelyHidden()
        {
            return true;
        }
}