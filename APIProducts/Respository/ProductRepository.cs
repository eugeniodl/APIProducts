using APIProducts.Models;
using APIProducts.Respository.IRepository;

namespace APIProducts.Respository
{
    public class ProductRepository : IProductRepository
    {
        private List<Product> _products = new List<Product>()
        {
            new Product() { Id = 1, Name = "Aceite", Brand = "Real"},
            new Product() { Id = 2, Name = "Leche", Brand = "Eskimo"}
        };
        public IEnumerable<Product> Get() => _products;

        public Product? GetById(int id) => _products.FirstOrDefault(p => p.Id == id);
    }
}
