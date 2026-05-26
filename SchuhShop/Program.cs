namespace SchuhShop
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>
            {
                new Product(1, "Nike Air Max", 120),
                new Product(2, "Adidas Superstar", 90),
                new Product(3, "Puma Runner", 80)
            };

            Cart cart = new Cart();

            while (true)
            {
                Console.WriteLine("\n=== Schuh Shop ===");
                Console.WriteLine("1. Produkte anzeigen");
                Console.WriteLine("2. In Warenkorb hinzufügen");
                Console.WriteLine("3. Warenkorb anzeigen");
                Console.WriteLine("4. Produkt entfernen");
                Console.WriteLine("0. Exit");

                Console.Write("Auswahl: ");
                string input = Console.ReadLine();

                if (input == "1")
                {
                    ShowProducts(products);
                }
                else if (input == "2")
                {
                    AddToCart(products, cart);
                }
                else if (input == "3")
                {
                    cart.ShowCart();
                }
                else if (input == "4")
                {
                    Console.Write("Produkt ID zum Entfernen: ");
                    int id = int.Parse(Console.ReadLine());
                    cart.RemoveProduct(id);
                }
                else if (input == "0")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Falsche Eingabe.");
                }
            }
        }

        static void ShowProducts(List<Product> products)
        {
            Console.WriteLine("\n=== Produkte ===");

            foreach (var p in products)
            {
                Console.WriteLine($"{p.Id}. {p.Name} - {p.Price} Euro");
            }
        }

        static void AddToCart(List<Product> products, Cart cart)
        {
            Console.Write("Produkt ID eingeben: ");

            int id = int.Parse(Console.ReadLine());

            var product = products.FirstOrDefault(p => p.Id == id);

            if (product != null)
            {
                cart.AddProduct(product);
                Console.WriteLine("Produkt wurde zum Warenkorb hinzugefügt.");
            }
            else
            {
                Console.WriteLine("Produkt nicht gefunden.");
            }
        }
    }
}