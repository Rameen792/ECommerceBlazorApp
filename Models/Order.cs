namespace ECommerceBlazorApp.Models
{
    public class Order
    {
        public string CustomerName { get; set; } = "";

        public string Address { get; set; } = "";

        public string ContactNumber { get; set; } = "";

        // default to 1 so TotalPrice isn't zero unless user sets quantity explicitly
        public int Quantity { get; set; } = 1;

        // allow SelectedProduct to be null and guard TotalPrice
        public Product? SelectedProduct { get; set; } = new Product();

        public double TotalPrice => Quantity * (SelectedProduct?.Price ?? 0);
    }
}