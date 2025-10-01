using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");

        Video video = new Video("Learn React with this ONE project", "Tech With Tim", 5970);
        Comment comment = new Comment("ElenaS-de9hq", "I would like to see more of your projects with Windsurf.");
        Comment comment1 = new Comment("MonthS-m2r", "Windsurf is great at teaching programming");
        Comment comment2 = new Comment("FebinAugustine", "Hi Tim that's a good one... Could you please do the same like this where it's clear how to do register, login with backend. Also please tell how to use token and cookies.");

        Video video1 = new Video("Python Full Course for free", "Bro Code", 43200);
        Comment comment3 = new Comment("Layuxz", "I'm just commenting to support. Honestly flabbergasted you posted 12 hours of real content for free. Bro is destroying the competition.");
        Comment comment4 = new Comment("J_y87", "Seriously,he make everything free and fundraising for the hospital.Mad respect for this gigachad");
        Comment comment5 = new Comment("ChessAnalysis-ys8cj", "Bro casually dropped 12 hours of content for free");

        Video video2 = new Video("Spiritual Dynamite", "The Church of Jesus Christ of Latter-day Saints", 160);
        Comment comment6 = new Comment("doodeldeiflutterby6232", "That is actually a great visualisation of faith, and how it feels");
        Comment comment7 = new Comment("ClintGoodman27", "I liked this.  I appreciate the reminder.  I'm talking with my wife right now about how I need to make an actionable goal to do more family history work.  Love Mormon Messages.");
        Comment comment8 = new Comment("ricardop.maganha5408", "I felt that powerful peace when I was on the Temple! Unforgettable.");

        video.AddComment(comment);
        video.AddComment(comment1);
        video.AddComment(comment2);

        video1.AddComment(comment3);
        video1.AddComment(comment4);
        video1.AddComment(comment5);

        video2.AddComment(comment6);
        video2.AddComment(comment7);
        video2.AddComment(comment8);

        List<Video> videos = [video, video1, video2];

        foreach (Video vid in videos)
        {
            vid.Display();
            Console.WriteLine();
        }


    }
}