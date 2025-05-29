using System;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("Top 10 Temples", "LDS-Living", 345);
        video1.AddComment(new Comment("David", "Awesome Video!"));
        video1.AddComment(new Comment("Sarah", "Very informative, thanks!"));
        video1.AddComment(new Comment("John", "Loved the visuals!"));
        video1.AddComment(new Comment("Emily", "Great content, keep it up!"));

        Video video2 = new Video("Most Powerful Scriptures", "LDS-Living", 520);
        video2.AddComment(new Comment("Michael", "Inspiring!"));
        video2.AddComment(new Comment("Anna", "This changed my perspective!"));
        video2.AddComment(new Comment("Chris", "Thank you for sharing!"));
        video2.AddComment(new Comment("Laura", "Beautifully explained!"));

        Video video3 = new Video("Understanding the Gospel", "LDS-Living", 600);
        video3.AddComment(new Comment("James", "Very enlightening!"));
        video3.AddComment(new Comment("Sophia", "I learned a lot from this!"));
        video3.AddComment(new Comment("Oliver", "Excellent breakdown of concepts!"));
        video3.AddComment(new Comment("Mia", "This was very helpful, thank you!"));

        List<Video> videos = new List<Video> { video1, video2, video3 };
        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.Title} \n Author: {video.Author} \n Length: {video.Length} seconds\n Number of Comments: {video.commentnumber()}");
            Console.WriteLine("Comments:");
            foreach (Comment comment in video.comments)
            {
                Console.WriteLine($"{comment.author}:{comment.text}");
            }
            Console.WriteLine();
        }
    }
}