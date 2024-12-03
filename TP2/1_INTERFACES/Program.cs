using System;
using System.Collections.Generic;

namespace Article
{
    public enum Type
    {
        Alimentaire,
        Droguerie,
        Habillement,
        Loisir
    }

    public interface IRentable
    {
        void CalculateRent();
    }

    public class Article : IRentable
    {
        public string Name;
        public double Price;
        public int Quantity;
        public Type Type;

        public Article(string name, double price, int quantity, Type type)
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

        public void AddArticle(int amount)
        {
            if (amount > 0)
            {
                Quantity += amount;
                Console.WriteLine($"{amount} nouveau {Name} ont été ajoutés au stock.");
            }
            else
            {
                Console.WriteLine("La quantité doit être supérieure à 0.");
            }
        }

        public void RemoveArticle(int amount)
        {
            if (amount > 0)
            {
                Quantity -= amount;
                Console.WriteLine($"{amount} {Name} ont été retirés du stock.");
            }
            else
            {
                Console.WriteLine("La quantité doit être supérieure à 0.");
            }
        }

        public void CalculateRent()
        {
            double rent = Price * Quantity * 0.05;
            Console.WriteLine($"Rentabilité pour {Name} ({Type}) : {rent}€");
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            List<IRentable> articles = new List<IRentable>
            {
                new Article("Ordinateur", 1490.90, 30, Type.Loisir),
                new Article("Carotte", 1.90, 130, Type.Alimentaire),
                new Article("Pantalon", 79.90, 80, Type.Habillement)
            };

            Console.WriteLine("Articles disponibles :");
            foreach (Article article in articles)
            {
                article.ShowArticle();
            }

            // Calcul des rentabilités
            Console.WriteLine("\nCalcul des rentabilités :");
            foreach (IRentable article in articles)
            {
                article.CalculateRent();
            }
        }
    }
}
