using APIProducts.Controllers;
using APIProducts.Respository;
using APIProducts.Respository.IRepository;
using Microsoft.AspNetCore.Mvc;
using Xunit;

namespace UnitTesting
{
    public class ProductTesting
    {
        private readonly ProductsController _controller;
        private readonly IProductRepository _repository;

        public ProductTesting()
        {
            _repository = new ProductRepository();
            _controller = new ProductsController(_repository);
        }

        [Fact]
        public void Get_Ok()
        {
            var result = _controller.Get();

            Assert.IsType<OkObjectResult>(result);
        }
    }
}