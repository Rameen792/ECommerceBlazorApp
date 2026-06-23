using ECommerceBlazorApp.Models;

namespace ECommerceBlazorApp.Services
{
    public class ProductService
    {
        private List<Product> products = new List<Product>()
    {
        new Product { Id = 1, Name = "Laptop", Price = 80000, ImageUrl = "images/laptop.jpg" },
        new Product { Id = 2, Name = "Phone", Price = 50000, ImageUrl = "images/phone.avif" },
        new Product { Id = 3, Name = "Headphones", Price = 5000, ImageUrl = "images/headphones.avif" },
        new Product { Id = 4, Name = "IPad", Price = 70000, ImageUrl = "images/ipad.jpeg" },
        new Product { Id = 5, Name = "Controller", Price = 7000, ImageUrl = "images/z.jpg" },
        new Product { Id = 6, Name = "Camera", Price = 10000, ImageUrl = "images/camera.jpg" },
        new Product { Id = 7, Name = "EarPhones", Price = 2000, ImageUrl = "images/earphones.avif" },
        new Product { Id = 8, Name = "Cables", Price = 3000, ImageUrl = "images/cables.avif" },
        new Product { Id = 9, Name = "EarBuds", Price = 7000, ImageUrl = "images/earbuds.avif" },
        new Product { Id = 10, Name = "Charger", Price = 6000, ImageUrl = "images/charger.avif" },
        new Product { Id = 11, Name = "Watch", Price = 5000, ImageUrl = "images/watch.avif" },
        new Product { Id = 12, Name = "Mouse", Price = 6000, ImageUrl = "images/mouse.avif" }


    };

        public List<Product> GetProducts()
        {
            return products;
        }

        public Product GetProductById(int id)
        {
            return products.FirstOrDefault(p => p.Id == id);
        }
    }
}
