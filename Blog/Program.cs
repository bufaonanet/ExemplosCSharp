using System;
using Blog.Entities;

namespace Blog
{
    class Program
    {
        static void Main(string[] args)
        {
            Comment c1 = new Comment("Have a nice trip");
            Comment c2 = new Comment("Wow That's awesome! ");

            Post p1 = new Post(
                DateTime.Parse("21/06/2018 13:05:44"),
                "Traveling new zeland",
                "I'm going to visiti this wonderfull country!",
                12
                );

            p1.AddComent(c1);
            p1.AddComent(c2);

            Comment c4 = new Comment("Good Night");
            Comment c5 = new Comment("My the force be with you!");

            Post p2 = new Post(
                DateTime.Parse("28/07/2018 23:14:44"),
                "Good night guys",
                "See you tomorrow",
                5
                );

            p2.AddComent(c4);
            p2.AddComent(c5);

            Console.WriteLine(p1);
            Console.WriteLine(p2);
        }
    }
}
