using System;
using YouTubeVideos;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("C# Programming All-in-One Tutorial Series", "Caleb Curry", 21600);
        video1.AddComment(new Comment("Tutorial7a", "Just finished this course—and let me just say: thank you SO much!!"));
        video1.AddComment(new Comment("Sunova_", "bro... i'm just 30 minutes into this and already blowing my mind how simple you make this for me to understand. Thank you so much"));
        video1.AddComment(new Comment("Dannyh807", "Just finished this over 2 days in time to start my OOP C# module in uni and wow man just thank you for giving me a nice broad understanding."));
        videos.Add(video1);

        Video video2 = new Video("Learn Python - Full Course for Beginners [Tutorial]", "freeCodeCamp.org", 15600);
        video2.AddComment(new Comment("CodeMaster", "This is the best Python tutorial I've ever seen. Thank you!"));
        video2.AddComment(new Comment("Pythonista", "Great course! I learned so much."));
        video2.AddComment(new Comment("Jonh", "Thank you, I liked it"));
        videos.Add(video2);

        Video video3 = new Video("JavaScript Tutorial for Beginners: Learn JavaScript in 1 Hour", "Programming with Mosh", 3600);
        video3.AddComment(new Comment("JSDev", "Awesome tutorial! Very clear and concise."));
        video3.AddComment(new Comment("WebCoder", "This helped me a lot. Thanks!"));
        video3.AddComment(new Comment("Cecilia", "Really good video!"));
        videos.Add(video3);

        foreach (var vid in videos)
        {
            Console.WriteLine("Title: " + vid.GetTitle());
            Console.WriteLine("Author: " + vid.GetAuthor());
            Console.WriteLine("Duration: " + vid.GetSeconds() + " seconds");
            Console.WriteLine("Number of comments: " + vid.GetCommentCount());

            foreach (var comment in vid.GetComments())
            {
                Console.WriteLine("Comment: " + comment.GetComment() + " by: " + comment.GetName());
            }
            Console.WriteLine();
        }
    }
}
