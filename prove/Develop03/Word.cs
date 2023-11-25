
using System;
using System.Dynamic;

public class Word // Keeps track of a single word and whether it is shown or hidden
{
    // private static char[] seperators = new char[] {' ', ',', ';', '.'};
    // private static string _text = "If any of you lack wisdom, let him ask of God, that giveth to all men liberally, and upbraideth not; and it shall be given him.";
    private bool _isHidden;
    private static string[] _text = {"If", "any", "of", "you", "lack", "wisdom,", "let", "him", "ask", "of", "God,", "that", "giveth", "to", "all", "men", "liberally,", "and", "upbraideth", "not;", "and", "it", "shall", "be", "given", "him."};
   
    // _text.Split(seperators, StringSplitOptions.RemoveEmptyEntries);
    
    
    public static void Hide()
    {
       Random ranNum = new Random();
       int ranNumbr = ranNum.Next(0, _text.Length);

       string ranWord = _text[ranNumbr];

       while (_text.Length > 0)
       {
            string goneWord = "";
            for (int charNumbr = 0; charNumbr < ranWord.Length; charNumbr++)
            {
                string dash =("_");
                goneWord += dash;
                _text[ranNumbr] = goneWord;
            }
            Console.WriteLine(goneWord);
            Console.WriteLine("{0}", string.Join(" ", _text));
       };
    
    }
    public void Show()
    {
        _isHidden = false;
    }
    public bool IsHidden()
    {
        return true;
    }
    public static void GetDisplayText()
    {    
        // Console.WriteLine("This is working");

        // foreach (var word in _text)
        // {
        //     Console.WriteLine($"Words: {word}");
        // }
    }
}
