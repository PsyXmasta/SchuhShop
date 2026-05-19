namespace SchuhShop;


class Product

{

    public int Id;

    public string Name;

    public double Price;

}


class Program
{
    static void Main()
    {
        List<Product> products = new List<Product>
            {
                new Product { Id = 1, Name = "Nike Air Max", Price = 120 },

                new Product { Id = 2, Name = "Adidas Superstar", Price = 90 },

                new Product { Id = 3, Name = "Puma Runner", Price = 80 }
            };



        Console.WriteLine("Produktliste:");



        foreach (var p in products)

        {

            Console.WriteLine(p.Id + ": " + p.Name + " - " + p.Price + "€");

        }

    }

}
