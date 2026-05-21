
using System;
using System.Collections.Generic;

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

            while (true)
            {
                Console.WriteLine("\n=== Schuh Shop ===");
                Console.WriteLine("1. Produkte anzeigen");
                Console.WriteLine("0. Exit");

                Console.Write("Auswahl: ");
                string input = Console.ReadLine();

                if (input == "1")
                {
                    ShowProducts(products);
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

            foreach (Product p in products)
            {
                Console.WriteLine(p.Id + ". " + p.Name + " - " + p.Price + "€");
            }
        }
    }
}
