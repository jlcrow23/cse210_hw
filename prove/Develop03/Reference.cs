public class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;

    public string GetDisplayText()
    {
        return "Hi!";
    };

    public ScriptureRef(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
    };

    public ScriptureRef(string book, int chapter, int verse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = endVerse;
    }
    public string GetScripRef()
    {
        string text = $"{_book} {_chapter}:{_verse}";
        return text;
    };
    public string GetFullScripRef()
    {
        string text = $"{_book} {_chapter}:{_verse}-{_endVerse}"
        return text;
    }


    // public void SetScriptureReference()
    // {
    //     _book = book;
    //     _chapter = chapter;
    //     _verse = verse;
    //     _endVerse = endVerse;

    // };

}