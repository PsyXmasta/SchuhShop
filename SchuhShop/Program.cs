using System;
using System.Collections.Generic;

namespace SchuhShop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Willkommen im Schuh Shop!\n");

            List<Product> products = new List<Product>
            {
                new Product(1, "Nike Air Max", 120),
                new Product(2, "Adidas Superstar", 90),
                new Product(3, "Puma Runner", 80)
            };

            Console.WriteLine("Unsere Produkte:");

            foreach (var product in products)
            {
                Console.WriteLine($"{product.Id}. {product.Name} - {product.Price} Euro");
            }
        }
    }
}