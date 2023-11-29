public class PictureActivity : Activity
{
    private static List<string> _prompts = new List<string>();
    private static List<string> _questions = new List<string>();
    public static List<string> _Prompts 
    {
        get
        {
            return _prompts;
        }
        set
        {
            _prompts = value;
        }
    }
    public static List<string> _Questions 
    {
        get
        {
            return _questions;
        }
        set
        {
            _questions = value;
        }
    }
    public static void Run()
    {
        Console.WriteLine("Ready?");
        Thread.Sleep(2000);
        Console.WriteLine("Begin...");
        Thread.Sleep(2000);
        Console.Clear();
        Console.WriteLine(PictureActivity.GetRandomPrompt());
        Console.WriteLine("");
        Thread.Sleep(5000);

        var currentTime = DateTime.Now;
        while(DateTime.Now - currentTime < TimeSpan.FromSeconds(_duration))
        {
            Console.WriteLine(PictureActivity.GetRandomQuestion());
            Thread.Sleep(10000);
        }
        Console.WriteLine("Do you remember is more clearly?");
        Thread.Sleep(2000);
    }

    public static string GetRandomPrompt()
    {
        _Prompts.Add("Picture your first date with your current significant other...");
        _Prompts.Add("Picture your first visit to the temple...");
        _Prompts.Add("Picture a favorite family vacation...");
        _Prompts.Add("Picture the first time you went out of your own state(country)...");

        Random randomPrompt = new Random();
        string prompt = _Prompts[randomPrompt.Next(0, 3)];
        return prompt;
    }

    public static string GetRandomQuestion()
    {
        _Questions.Add("What colors do you see?");
        _Questions.Add("Who was with you?");
        _Questions.Add("What can you smell?");
        _Questions.Add("What textures do you feel?");
        _Questions.Add("What is the dominant feeling?");
        _Questions.Add("What were you wearing?");

        Random randomQuestion = new Random();
        string question = _Questions[randomQuestion.Next(0, 5)];
        return question;
    }
}
