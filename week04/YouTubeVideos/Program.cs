using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine();

        Video v1 = new Video("C# Classes and Objects Explained", "DevTutor", 600);
        Video v2 = new Video("Beginner's Guide to Python", "CodeWithAmy", 840);
        Video v3 = new Video("Debugging Tips for Java Developers", "TechGuru", 720);
        Video v4 = new Video("Understanding JavaScript Async/Await", "WebDevPro", 900);

        // COMMENTS FOR VIDEOS
        v1.AddComment(new Comment("Alice", "This finally helped me understand objects!"));
        v1.AddComment(new Comment("Bob", "Your example made classes so easy to follow."));
        v1.AddComment(new Comment("Cathy", "Could you make a video about inheritance next?"));

        v2.AddComment(new Comment("Dave", "I'm new to programming—this helped a ton."));
        v2.AddComment(new Comment("Emma", "Your explanation of loops was super clear."));
        v2.AddComment(new Comment("Frank", "Can you cover Python dictionaries in a future video?"));

        v3.AddComment(new Comment("Grace", "The breakpoint trick blew my mind!"));
        v3.AddComment(new Comment("Henry", "I fixed a bug because of this tutorial."));
        v3.AddComment(new Comment("Iris", "More Java debugging videos, please!"));

        v4.AddComment(new Comment("Jacob", "Finally, someone explained async/await clearly!"));
        v4.AddComment(new Comment("Laura", "The promise chain comparison was super helpful."));
        // v4.AddComment(new Comment("Sam", "Please make a video on JavaScript event loops next!"));

        // LIST OF VIDEOS
        List<Video> videos = new List<Video> { v1, v2, v3, v4 };

        // DISPLAY RESULTS OF ALL V&C
        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video._title}");
            Console.WriteLine($"Author: {video._author}");
            Console.WriteLine($"Length (sec): {video._lengthSeconds}");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");
            Console.WriteLine("Comments:");

            foreach (Comment c in video.GetComments())
            {
                Console.WriteLine($" - {c._commenterName, -6}: {c._text}");
            }

            Console.WriteLine();
        }
    }
}