using System;
using System.Collections.Generic;

namespace LINQ
{
    public enum TypeArticle
    {
        Alimentaire,
        Droguerie,
        Habillement,
        Loisir
    }

    public class ArticleType
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public TypeArticle Type { get; set; }

        public ArticleType(string name, double price, int quantity, TypeArticle type)
        {
            this.Name = name;
            this.Price = price;
            this.Quantity = quantity;
            this.Type = type;
        }

        public void ShowArticle()
        {
            Console.WriteLine($"Nom : {Name}, Prix : {Price}€, Quantité : {Quantity}, Type : {Type}");
        }
    }

    public static class ArticleExtensions
    {
        public static void AfficherTous(this List<ArticleType> articles)
        {
            foreach (var article in articles)
            {
                article.ShowArticle();
            }
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            List<ArticleType> articles = new List<ArticleType>
            {
                new ArticleType("Pomme", 2.5, 50, TypeArticle.Alimentaire),
                new ArticleType("Savon", 3.2, 30, TypeArticle.Droguerie),
                new ArticleType("T-shirt", 15.0, 20, TypeArticle.Habillement),
                new ArticleType("Chaussures", 50.0, 5, TypeArticle.Habillement)
            };

            Console.WriteLine("Liste des articles :");
            articles.AfficherTous();
        }
    }
}
