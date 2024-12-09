using System;

class Program
{
    static void Main(string[] args)
    {
    
        List<Video> videos = new List<Video>();

       
        Video video1 = new Video("Tech Review 2024", "TechTube", 1200);
        video1.AddComment(new Comment("UserA", "Great review!"));
        video1.AddComment(new Comment("UserB", "Very informative"));
        video1.AddComment(new Comment("UserC", "Loved the details"));
        videos.Add(video1);

     
        Video video2 = new Video("Cooking Basics", "ChefCentral", 900);
        video2.AddComment(new Comment("FoodLover", "Amazing tutorial"));
        video2.AddComment(new Comment("Amateur Cook", "Learned so much"));
        videos.Add(video2);

    
        Video video3 = new Video("Travel Vlog", "WorldExplorer", 1800);
        video3.AddComment(new Comment("Traveler99", "Stunning locations!"));
        video3.AddComment(new Comment("DreamTripper", "Inspiring journey"));
        video3.AddComment(new Comment("GlobeTrotter", "Where is this?"));
        video3.AddComment(new Comment("Tourist", "Beautiful cinematography"));
        videos.Add(video3);

       
        Console.WriteLine("Video Tracking System\n");
        foreach (var video in videos)
        {
            video.DisplayVideoDetails();
        }
    }
}