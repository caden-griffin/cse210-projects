using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("This is Not a Video", "Joker", 60000);
        video1.AddComment(new Comment("Hyrum", "This is a long video!"));
        video1.AddComment(new Comment("Ava", "Wow."));
        video1.AddComment(new Comment("Cooper", "Why is this so long?"));
        videos.Add(video1);

        Video video2 = new Video("How to Sleep Fast", "Sleeper", 120);
        video2.AddComment(new Comment("Aunie", "Thanks! I needed this."));
        video2.AddComment(new Comment("Kristin", "Now I can finally sleep."));
        video2.AddComment(new Comment("Robert", "I can already sleep easily."));
        videos.Add(video2);

        Video video3 = new Video("Pizza Sauce Recipe", "YouTuber", 600);
        video3.AddComment(new Comment("Kamryn","I need to try this soon!"));
        video3.AddComment(new Comment("Gabe","I can't wait to taste it!"));
        video3.AddComment(new Comment("Josh","I need to make this for my son."));
        video3.AddComment(new Comment("Zach","I gotta try this."));
        videos.Add(video3);

        Video video4 = new Video("Trying Random Food", "Eater", 1600);
        video4.AddComment(new Comment("Tyson","That second food looks weird!"));
        video4.AddComment(new Comment("Owen","I don't think I could eat the second one!"));
        video4.AddComment(new Comment("Joe","That second food is my favorite food!"));
        videos.Add(video4);


        foreach (Video video in videos)
        {
            Console.WriteLine("-------------------------------");
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.Length} seconds");
            Console.WriteLine($"Number of Comments: {video.GetCommentCount()}");
            Console.WriteLine();

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"-{comment.Name}: {comment.Text}");
            }
            Console.WriteLine();
        }
    }
}