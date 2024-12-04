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
                new ArticleType("Banane", 2.5, 50, TypeArticle.Alimentaire),
                new ArticleType("Shampoing", 3.2, 30, TypeArticle.Droguerie),
                new ArticleType("Slip", 15.0, 20, TypeArticle.Habillement),
            };

            Console.WriteLine("Liste des articles initialisée :");
            foreach (var article in articles)
            {
                article.ShowArticle();
            }

            Console.WriteLine();

            var alimentaires = articles.Where(a => a.Type == TypeArticle.Alimentaire);
            Console.WriteLine("Articles de type Alimentaire :");
            foreach (var article in alimentaires)
            {
                article.ShowArticle();
            }

            Console.WriteLine();

            var sortedByPrice = articles.OrderByDescending(a => a.Price);
            Console.WriteLine("Articles triés par prix décroissant :");
            foreach (var article in sortedByPrice)
            {
                article.ShowArticle();
            }

            Console.WriteLine();

            int totalStock = articles.Sum(a => a.Quantity);
            Console.WriteLine($"Stock total de tous les articles : {totalStock}");
        }
    }
}
