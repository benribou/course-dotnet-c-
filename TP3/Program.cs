using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

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

            string filePath = "articles.json";

            Console.WriteLine("Exportation des articles en JSON...");
            string json = JsonSerializer.Serialize(articles, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(filePath, json);
            Console.WriteLine("Articles exportés dans le fichier 'articles.json'.\n");

            Console.WriteLine("Importation des articles depuis JSON...");
            if (File.Exists(filePath))
            {
                string importedJson = File.ReadAllText(filePath);
                List<ArticleType> importedArticles = JsonSerializer.Deserialize<List<ArticleType>>(importedJson);

                Console.WriteLine("Articles importés :");
                foreach (var article in importedArticles)
                {
                    article.ShowArticle();
                }
            }
            else
            {
                Console.WriteLine("Le fichier JSON n'existe pas.");
            }
        }
    }
}
