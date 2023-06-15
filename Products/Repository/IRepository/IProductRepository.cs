using Products.Models;

namespace Products.Repository.IRepository
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetProducts();

        Product? GetById(int id);
    }
}
