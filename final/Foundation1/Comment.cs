public class Comment
{
    public string _name;
    public string _text;
    public void Display()
    {
        // List<string> coms = new List<string>();

        // Console.WriteLine(coms.Count);

        Console.WriteLine($"Name: {_name}\nComment: {_text}");
        // Console.WriteLine(string.Count);
    }
}