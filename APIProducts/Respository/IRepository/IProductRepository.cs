using APIProducts.Models;

namespace APIProducts.Respository.IRepository
{
    public interface IProductRepository
    {
        IEnumerable<Product> Get();
        Product? GetById(int id);
    }
}
