using System;
using System.Collections.Generic;
using System.Linq;

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

    public class Program
    {
        public static void Main(string[] args)
        {
            var mixedCollection = new List<object>
            {
                new ArticleType("Pomme", 2.5, 50, TypeArticle.Alimentaire),
                new ArticleType("Savon", 3.2, 30, TypeArticle.Droguerie),
                "Ceci est une chaîne",
                42,
                DateTime.Now,
                new ArticleType("T-shirt", 15.0, 20, TypeArticle.Habillement)
            };

            var onlyArticles = mixedCollection.OfType<ArticleType>();

            Console.WriteLine("Articles extraits de la collection mixte :");
            foreach (var article in onlyArticles)
            {
                article.ShowArticle();
            }
        }
    }
}
