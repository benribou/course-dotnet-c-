using System;
using System.Collections.Generic;

namespace Publications
{
    public abstract class Publication
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public double Price { get; set; }

        public Publication(string title, string author, double price)
        {
            this.Title = title;
            this.Author = author;
            this.Price = price;
        }

        public abstract void PublishDetails();
    }

    public class Livre : Publication
    {
        public int Pages { get; set; }

        public Livre(string title, string author, double price, int pages)
            : base(title, author, price)
        {
            this.Pages = pages;
        }

        public override void PublishDetails()
        {
            Console.WriteLine($"Livre : {Title} par {Author}, {Price}€, {Pages} pages.");
        }
    }

    public class Disque : Publication
    {
        public string Format { get; set; }

        public Disque(string title, string author, double price, string format)
            : base(title, author, price)
        {
            this.Format = format;
        }

        public override void PublishDetails()
        {
            Console.WriteLine($"Disque : {Title} par {Author}, {Price}€, Format : {Format}.");
        }
    }

    public class Video : Publication
    {
        public int Duration { get; set; }

        public Video(string title, string author, double price, int duration)
            : base(title, author, price)
        {
            this.Duration = duration;
        }

        public override void PublishDetails()
        {
            Console.WriteLine($"Vidéo : {Title} par {Author}, {Price}€, Durée : {Duration} minutes.");
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            List<Publication> publications = new List<Publication>
            {
                new Livre("Les Misérables", "Victor Hugo", 25.90, 1232),
                new Disque("Abbey Road", "The Beatles", 19.99, "Vinyle"),
                new Video("Inception", "Christopher Nolan", 14.99, 148)
            };

            Console.WriteLine("Détails des publications :");
            foreach (var publication in publications)
            {
                publication.PublishDetails();
            }
        }
    }
}
