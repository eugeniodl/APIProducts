using APIProducts.Models;
using APIProducts.Services.IServices;

namespace APIProducts.Services
{
    public class ProductService : IProductService
    {
        private List<Product> _products = new List<Product>
        {
            new Product() { Id =1 , Name = "Aceite", Brand = "Ambar"},
            new Product() { Id =2 , Name = "Leche", Brand = "Nestle" }
        };
        public Product? GetProductById(int id) => _products.FirstOrDefault(p => p.Id == id);

        public IEnumerable<Product> GetProducts() => _products;

    }
}
