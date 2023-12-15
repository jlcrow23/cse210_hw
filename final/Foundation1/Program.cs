using System;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video();
        video1._title = "Puppy with squirrel";
        video1._author = "Wayne Little";
        video1._length = 120;

        Comment commentV1a = new Comment();
        commentV1a._name = "Bob Star";
        commentV1a._text = "Great video. So funny!";

        Comment commentV1b = new Comment();
        commentV1b._name = "Bing Crosby";
        commentV1b._text = "Loved it!";
        
        Video video2 = new Video();
        video2._title = "Girl singing Twinkle";
        video2._author = "Patty Pepper";
        video2._length = 145;

        Comment commentV2a = new Comment();
        commentV2a._name = "Jorge Saul";
        commentV2a._text = "Aww! So sweet!";

        Video video3 = new Video();
        video3._title = "Stinky skunk chasing cat";
        video3._author = "Sarah Mitchell";
        video3._length = 45;

        Comment commentV3a = new Comment();
        commentV3a._name = "Julie Sam";
        commentV3a._text = "So Funny! LOL!";

        video1.comments.Add(commentV1a);
        video1.comments.Add(commentV1b);

        video2.comments.Add(commentV2a);

        video3.comments.Add(commentV3a);

        video1.Display();
        video2.Display();
        video3.Display();
        // Comment myComment = new Comment();
        // myComment._name = "Bob Star";
        // myComment._text = "This is so cute! Keep up the good work!";



    }
}