public class Video
{
    public string _author;
    public string _title;
    public int _length;
    public List<Comment> comments = new List<Comment>();
    public void Display()
    {
        Console.WriteLine($"\nTitle: {_title}\nAuthor: {_author}\nLength: {_length}");
        Console.WriteLine($"Comments: {comments.Count}");
        

        foreach (Comment comment in comments)
        {
            comment.Display();
        }
    }
}