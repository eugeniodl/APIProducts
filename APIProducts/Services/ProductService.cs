using APIProducts.Models;
using APIProducts.Services.IServices;

namespace APIProducts.Services
{
    public class ProductService : IProductService
    {
        private List<Product> _products = new List<Product>
        {
            new Product() { IdProduct =1 , ProductName = "Aceite", Brand = "Corona"},
            new Product() { IdProduct =2 , ProductName = "Leche", Brand = "Centrolac" }
        };
        public Product? GetProductById(int id) => _products.FirstOrDefault(p => p.IdProduct == id);

        public IEnumerable<Product> GetProducts() => _products;

    }
}
