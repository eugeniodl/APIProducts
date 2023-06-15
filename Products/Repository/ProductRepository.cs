using Products.Models;
using Products.Repository.IRepository;

namespace Products.Repository
{
    public class ProductRepository : IProductRepository
    {
        private List<Product> _products = new List<Product>
        {
            new Product { Id = 1, Name = "Aceite", Brand = "Mazola" },
            new Product { Id = 2, Name = "Leche", Brand = "Lala" }
        };
        public Product? GetById(int id) => _products.FirstOrDefault(p => p.Id == id);

        public IEnumerable<Product> GetProducts() => _products;
    }
}
