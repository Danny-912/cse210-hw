using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");
    
        List<Video> videos = new List<Video>();
      {
        Video video1 = new Video("C# Basics", "John Dev", 600);
        video1.AddComment(new Comment("Alice", "Very helpful"));
        video1.AddComment(new Comment("Mark", "Nice explanation"));
        video1.AddComment(new Comment("Sarah", "I understand now"));

        Video video2 = new Video("OOP Concepts", "Code Master", 750);
        video2.AddComment(new Comment("Tom", "Great video"));
        video2.AddComment(new Comment("Jerry", "Very clear"));
        video2.AddComment(new Comment("Lily", "Thanks!"));

        Video video3 = new Video("Encapsulation", "Tech Guru", 500);
        video3.AddComment(new Comment("Ben", "Awesome"));
        video3.AddComment(new Comment("Emma", "Now I get it"));
        video3.AddComment(new Comment("David", "Perfect explanation"));

        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        foreach (Video video in videos)
        {
            Console.WriteLine("Title: " + video._title);
            Console.WriteLine("Author: " + video._author);
            Console.WriteLine("Length: " + video._length + " seconds");
            Console.WriteLine("Comments: " + video.GetCommentCount());

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine("- " + comment._name + ": " + comment._text);
            }

            Console.WriteLine();
        }
    }}}
    
