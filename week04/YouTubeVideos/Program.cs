using System;

class Program
{
    static void Main(string[] args)
    {
       {
        List<Video> videos = new List<Video>();

        // Video 1
        Video video1 = new Video("How to Make Homemade Bread", "Maria's Kitchen", 320);
        video1.AddComment(new Comment("John", "I loved the recipe!"));
        video1.AddComment(new Comment("Clara", "It turned out delicious here at home."));
        video1.AddComment(new Comment("Lucas", "You explain things really well!"));
        videos.Add(video1);

        // Video 2
        Video video2 = new Video("Top 5 Games of 2025", "GameNerd", 780);
        video2.AddComment(new Comment("Peter", "You forgot Elden Ring 2, huh!"));
        video2.AddComment(new Comment("Anna", "Loved the video editing."));
        video2.AddComment(new Comment("James", "All amazing games!"));
        videos.Add(video2);

        // Video 3
        Video video3 = new Video("How to Learn English Fast", "Teacher Julia", 450);
        video3.AddComment(new Comment("Ralph", "I'm going to apply these tips."));
        video3.AddComment(new Comment("Matthew", "Very good!"));
        video3.AddComment(new Comment("Laura", "I'm already seeing results."));
        videos.Add(video3);

        // Display everything in the console
        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video._title}");
            Console.WriteLine($"Author: {video._author}");
            Console.WriteLine($"Length: {video._length} seconds");
            Console.WriteLine($"Number of comments: {video.GetNumberOfComments()}");
            Console.WriteLine("Comments:");
            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"- {comment._name}: {comment._text}");
            }
            Console.WriteLine("--------------------------------");
        }
    }
    }
}