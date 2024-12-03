using System;

namespace ArticleWithDelegate
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
    }

    public delegate double DiscountStrategy(Article article);

    public class Program
    {
        public static double FixedDiscount(Article article)
        {
            return article.Price * 0.10;
        }

        public static double TypeBasedDiscount(Article article)
        {
            return article.Type switch
            {
                Type.Alimentaire => article.Price * 0.05,
                Type.Habillement => article.Price * 0.20,
                _ => article.Price * 0.10
            };
        }

        public static double QuantityBasedDiscount(Article article)
        {
            if (article.Quantity > 100)
                return article.Price * 0.15;
            return 0;
        }

        public static void Main(string[] args)
        {
            Article ordinateur = new Article("Ordinateur", 1490.90, 30, Type.Loisir);
            Article carotte = new Article("Carotte", 1.90, 130, Type.Alimentaire);
            Article pantalon = new Article("Pantalon", 79.90, 80, Type.Habillement);

            Article[] articles = { ordinateur, carotte, pantalon };

            DiscountStrategy fixedDiscount = FixedDiscount;
            DiscountStrategy typeDiscount = TypeBasedDiscount;
            DiscountStrategy quantityDiscount = QuantityBasedDiscount;

            Console.WriteLine("Articles avec remises appliquées :\n");

            foreach (var article in articles)
            {
                article.ShowArticle();

                double fixedRemise = fixedDiscount(article);
                double typeRemise = typeDiscount(article);
                double quantityRemise = quantityDiscount(article);

                Console.WriteLine($"Remise fixe : {fixedRemise}€");
                Console.WriteLine($"Remise par type : {typeRemise}€");
                Console.WriteLine($"Remise par quantité : {quantityRemise}€");

                double finalPrice = article.Price - Math.Max(Math.Max(fixedRemise, typeRemise), quantityRemise);
                Console.WriteLine($"Prix final après la meilleure remise : {finalPrice}€\n");
            }
        }
    }
}
