using System;

namespace Article
{
    public enum Type 
    {
      Alimentaire,
      Droguerie,
      Habillement,
      Loisir
    }

    class Article
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
          if(amount > 0){
            Quantity = Quantity + amount;
            Console.WriteLine($"{amount} nouveau {Name} ont été ajouté aux stocks !");
          }
          else{
            Console.WriteLine("La quantité doit être supérieur à 0");
          }
        }

        public void RemoveArticle(int amount)
        {
          if(amount > 0){
            Quantity = Quantity - amount;
            Console.WriteLine($"{amount} {Name} à été retiré du stock !");
          }
          else{
            Console.WriteLine("La quantité doit être supérieur à 0");
          }
        }
    }

    class ProgramType
    {
        static void Main(string[] args)
        {
            Article[] articles = new Article[3];

            articles[0] = new Article("Ordinateur", 1490.90, 30, Type.Loisir);
            articles[1] = new Article("Carotte", 1.90, 130, Type.Alimentaire);
            articles[2] = new Article("Pantalon", 79.90, 80, Type.Habillement);

            Console.WriteLine("Articles :");
            foreach (var article in articles)
            {
                article.ShowArticle();
            }

            Console.WriteLine("\nModification des quantités :");
            articles[0].AddArticle(10);
            articles[1].RemoveArticle(20);
            articles[2].AddArticle(5);

            Console.WriteLine("\nArticles après modification :");
            foreach (var article in articles)
            {
                article.ShowArticle();
            }
        }
    }
}