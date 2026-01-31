using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("Fairytopia", "Princess123", 965);
        Video video2 = new Video("Living alone for 100 days!!", "Mr.Beat", 750);
        Video video3 = new Video("R.E.P.O", "CaseOhn", 455);

        video1.AddComment(new Comment("Becca123", "I love watching Barbie movies!"));
        video1.AddComment(new Comment("VeroSS", "I can't believe that actually happened"));
        video1.AddComment(new Comment("Leon", "Seems like I need to download this movie..."));

        video2.AddComment(new Comment("Brand0n17", "I can totally do this now problem"));
        video2.AddComment(new Comment("Jocygs", "WILD"));
        video2.AddComment(new Comment("Fiona_00", "For that money, I would do it too!"));

        video3.AddComment(new Comment("Pr0om97", "Me and my kids play this on repeat"));
        video3.AddComment(new Comment("Hannahhhh", "It can be kind of scary at times :("));
        video3.AddComment(new Comment("Ian1999", "I need to get more xp for my character"));

        List<Video> videos = new List<Video>
        {
            video1,
            video2,
            video3
        };

        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.LengthInSeconds} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");

            Console.WriteLine("Comments:");
            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($" - {comment.CommenterName}: {comment.Text}");
            }

            Console.WriteLine();
        }
    }
}
