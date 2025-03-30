using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        // Create and add videos with comments
        Video video1 = new Video("The Power of Faith", "Gospel Media", 300);
        video1.AddComment(new Comment("John", "This message touched my heart."));
        video1.AddComment(new Comment("Sarah", "Beautiful reminder!"));
        video1.AddComment(new Comment("Paul", "Exactly what I needed today."));
        videos.Add(video1);

        Video video2 = new Video("Scripture Insights", "StudyTime", 480);
        video2.AddComment(new Comment("Lisa", "Great explanation!"));
        video2.AddComment(new Comment("Tom", "Now I understand this verse."));
        video2.AddComment(new Comment("Anna", "Thanks for sharing."));
        videos.Add(video2);

        Video video3 = new Video("How to Journal Spiritually", "Faith Tools", 270);
        video3.AddComment(new Comment("Michael", "So helpful, thank you!"));
        video3.AddComment(new Comment("Emily", "I’ll start journaling today."));
        video3.AddComment(new Comment("Robert", "Excellent tips."));
        videos.Add(video3);

        // Display information of each video
        foreach (Video video in videos)
        {
            video.Display();
        }
    }
}