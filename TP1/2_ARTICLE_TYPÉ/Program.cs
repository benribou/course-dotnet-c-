using System;

namespace ArticleType
{
    public enum Type
    {
        Alimentaire,
        Droguerie,
        Habillement,
        Loisir
    }

    public class Article
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public Type Type { get; set; }

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
            Article ordinateur = new Article("Ordinateur", 1490.90, 30, Type.Loisir);
            Article carotte = new Article("Carotte", 1.90, 130, Type.Alimentaire);
            Article pantalon = new Article("Pantalon", 79.90, 80, Type.Habillement);

            Console.WriteLine("Articles de base :");
            ordinateur.ShowArticle();
            carotte.ShowArticle();
            pantalon.ShowArticle();

            Console.WriteLine("\nModification des quantités :");
            ordinateur.AddArticle(10);
            carotte.RemoveArticle(20);
            pantalon.AddArticle(5);

            Console.WriteLine("\nArticles après modification :");
            ordinateur.ShowArticle();
            carotte.ShowArticle();
            pantalon.ShowArticle();

            Console.WriteLine("\nCréation d'un nouvel article :");
            Console.Write("Entrez le nom de l'article : ");
            string name = Console.ReadLine();

            Console.Write("Entrez le prix de l'article : ");
            double price = Convert.ToDouble(Console.ReadLine());

            Console.Write("Entrez la quantité de l'article : ");
            int quantity = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Entrez le type de l'article (Alimentaire, Droguerie, Habillement, Loisir) :");
            string typeInput = Console.ReadLine();
            Type type = (Type)Enum.Parse(typeof(Type), typeInput, true);

            Article newArticle = new Article(name, price, quantity, type);

            Console.WriteLine("\nNouvel article créé :");
            newArticle.ShowArticle();
        }
    }
}
