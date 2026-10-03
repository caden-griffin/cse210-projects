using System;
using System.Collections.Generic;

namespace YouTubeVideos;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("C# Object-Oriented Programming", "Code Academy", 720);
        video1.AddComment(new Comment("Alice", "This made classes and objects click for me!"));
        video1.AddComment(new Comment("Bob", "Clear explanation of abstraction."));
        video1.AddComment(new Comment("Charlie", "Very helpful tutorial, thank you."));
        videos.Add(video1);

        Video video2 = new Video("Responsive Web Design with Grid and Flexbox", "Web Dev Simplified", 950);
        video2.AddComment(new Comment("Diana", "CSS Grid is a total game changer."));
        video2.AddComment(new Comment("Ethan", "Great pacing and practical examples."));
        video2.AddComment(new Comment("Fiona", "Subscribed! Can't wait for the next video."));
        videos.Add(video2);

        Video video3 = new Video("Advanced Minecraft Redstone Guide", "Redstone Guru", 1250);
        video3.AddComment(new Comment("George", "That observer elevator design is brilliant."));
        video3.AddComment(new Comment("Hannah", "Helped me fix my item sorter issue instantly."));
        video3.AddComment(new Comment("Ian", "Amazing tutorial! Keep it up."));
        videos.Add(video3);

        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.LengthInSeconds} seconds");
            Console.WriteLine($"Number of Comments: {video.GetCommentCount()}");
            Console.WriteLine("Comments:");

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"  - {comment.Name}: \"{comment.Text}\"");
            }

            Console.WriteLine();
            Console.WriteLine(new string('-', 40));
            Console.WriteLine();
        }
    }
}