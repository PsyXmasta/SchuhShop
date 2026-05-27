using System;
using System.Linq;
using System.Collections.Generic;

namespace SchuhShop
{
    public class Cart
    {
        public List<CartItem> Items = new List<CartItem>();

        public void AddProduct(Product product)
        {
            var item = Items.FirstOrDefault(i => i.Product.Id == product.Id);

            if (item != null)
            {
                item.Quantity++;
            }
            else
            {
                Items.Add(new CartItem(product));
            }
        }

        public void RemoveProduct(int productId)
        {
            var item = Items.FirstOrDefault(i => i.Product.Id == productId);

            if (item != null)
            {
                Items.Remove(item);
                Console.WriteLine("Produkt entfernt.");
            }
            else
            {
                Console.WriteLine("Produkt nicht im Warenkorb.");
            }
        }

        public void ShowCart()
        {
            Console.WriteLine("\n=== Warenkorb ===");

            if (Items.Count == 0)
            {
                Console.WriteLine("Warenkorb ist leer.");
                return;
            }

            foreach (var item in Items)
            {
                double total = item.Product.Price * item.Quantity;
                Console.WriteLine($"{item.Product.Name} x{item.Quantity} - {total} Euro");
            }

            Console.WriteLine("----------------------");
            Console.WriteLine($"Gesamt: {GetTotal()} Euro");
        }

        public double GetTotal()
        {
            return Items.Sum(i => i.Product.Price * i.Quantity);
        }
    }
}