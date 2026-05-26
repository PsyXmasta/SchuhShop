
namespace SchuhShop
{
    public class Cart
    {
        public List<CartItem> Items = new List<CartItem>();

        public void AddProduct(Product product)
        {
            var existingItem = Items.FirstOrDefault(i => i.Product.Id == product.Id);

            if (existingItem != null)
            {
                existingItem.Quantity++;
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
                Console.WriteLine(item.Product.Name + " x" + item.Quantity + " - " + (item.Product.Price * item.Quantity) + " Euro");
            }

            Console.WriteLine("Gesamt: " + GetTotal() + " Euro");
        }

        public double GetTotal()
        {
            return Items.Sum(i => i.Product.Price * i.Quantity);
        }
    }
}
