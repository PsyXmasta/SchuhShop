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
    }
}