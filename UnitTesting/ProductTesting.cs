using APIProducts.Controllers;
using APIProducts.Models;
using APIProducts.Services;
using APIProducts.Services.IServices;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Xunit;

namespace UnitTesting
{
    public class ProductTesting
    {
        private readonly ProductsController _controller;
        private readonly IProductService _service;

        public ProductTesting()
        {
            _service = new ProductService();
            _controller = new ProductsController(_service);
        }

        [Fact]
        public void Get_Ok()
        {
            var result = _controller.Get();

            Assert.IsType<OkObjectResult>(result);
        }

        [Fact]
        public void Get_Quantity()
        {
            var result = (OkObjectResult)_controller.Get();

            var products = Assert.IsType<List<Product>>(result.Value);
            Assert.True(products.Count > 0);
        }

        [Fact]
        public void GetById_Ok()
        {
            int id = 1;

            var result = _controller.GetById(id);

            Assert.IsType<OkObjectResult>(result);
        }

        [Fact]
        public void GetById_Exists()
        {
            // Arrange
            int id = 1;

            // Act
            var result = (OkObjectResult)_controller.GetById(id);

            // Assert
            var product = Assert.IsType<Product>(result?.Value);
            Assert.True(product != null);
            Assert.Equal(product?.IdProduct, id);
        }

        [Fact]
        public void GetById_NotFound()
        {
            // Arrange
            int id = 11;

            // Act
            var result = _controller.GetById(id);

            // Assert
            var product = Assert.IsType<NotFoundResult>(result);
        }
    }
}