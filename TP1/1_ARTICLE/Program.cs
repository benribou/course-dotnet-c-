using System;

namespace Article
{
    public class Article
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }

        public Article(string name, double price, int quantity)
        {
            this.Name = name;
            this.Price = price;
            this.Quantity = quantity;
        }

        public void ShowArticle()
        {
            Console.WriteLine($"Nom : {Name}, Prix : {Price}€, Quantité : {Quantity}");
        }

        public void AddArticle(int amount)
        {
            if (amount > 0)
            {
                Quantity += amount;
                Console.WriteLine($"{amount} nouveau(x) {Name} ont été ajoutés au stock.");
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
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            Article ordinateur = new Article("Ordinateur", 1490.90, 30);
            Article souris = new Article("Souris", 49.90, 130);
            Article clavier = new Article("Clavier", 79.90, 80);

            Console.WriteLine("Articles de base :");
            ordinateur.ShowArticle();
            souris.ShowArticle();
            clavier.ShowArticle();

            Console.WriteLine("\nModification des quantités :");
            ordinateur.AddArticle(10);
            souris.RemoveArticle(20);
            clavier.AddArticle(5);

            Console.WriteLine("\nArticles après modification :");
            ordinateur.ShowArticle();
            souris.ShowArticle();
            clavier.ShowArticle();

            Console.WriteLine("\nCréation d'un nouvel article :");

            Console.Write("Entrez le nom de l'article : ");
            string name = Console.ReadLine();

            Console.Write("Entrez le prix de l'article : ");
            double price = Convert.ToDouble(Console.ReadLine());

            Console.Write("Entrez la quantité de l'article : ");
            int quantity = Convert.ToInt32(Console.ReadLine());

            Article newArticle = new Article(name, price, quantity);

            Console.WriteLine("\nNouvel article créé :");
            newArticle.ShowArticle();
        }
    }
}