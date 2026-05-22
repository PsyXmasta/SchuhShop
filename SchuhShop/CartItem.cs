namespace SchuhShop
{
    public class CartItem
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }

        public CartItem(Product product)
        {
            Product = product;
            Quantity = 1;
        }
    }
}
