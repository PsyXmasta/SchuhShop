namespace SchuhShop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Willkommen im Schuh Shop!");
            
            Product product = new Product();
            Cart cart = new Cart();
            CartItem cartItem = new CartItem();
            ShopService shopService = new ShopService();
        }
    }
}
