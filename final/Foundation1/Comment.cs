public class Comment
{
    public string _name;
    public string _text;
    public void Display()
    {
        Console.WriteLine($"Name: {_name}\nComment: {_text}");
    }
}