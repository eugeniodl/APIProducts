using APIProducts.Models;

namespace APIProducts.Services.IServices
{
    public interface IProductService
    {
        IEnumerable<Product> GetProducts();
        Product? GetProductById(int id);
    }
}
