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
            List<ArticleType> articles = new List<ArticleType>
            {
                new ArticleType("Pomme", 2.5, 50, TypeArticle.Alimentaire),
                new ArticleType("Savon", 3.2, 30, TypeArticle.Droguerie),
                new ArticleType("T-shirt", 15.0, 20, TypeArticle.Habillement),
                new ArticleType("Chaussures", 50.0, 5, TypeArticle.Habillement)
            };

            var simplifiedView = articles.Select(a => new { a.Name, a.Price });

            Console.WriteLine("Vue simplifiée des articles (Nom et Prix) :");
            foreach (var item in simplifiedView)
            {
                Console.WriteLine($"Nom : {item.Name}, Prix : {item.Price}€");
            }
        }
    }
}
