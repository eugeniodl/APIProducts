using APIProducts.Respository.IRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APIProducts.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductRepository _productRepo;

        public ProductsController(IProductRepository productRepo)
        {
            _productRepo = productRepo;
        }

        [HttpGet]
        public IActionResult Get() => Ok(_productRepo.Get());

        [HttpGet("{id}")]
        public IActionResult GetById(int Id)
        {
            var product = _productRepo.GetById(Id);
            if(product == null)
                return NotFound();

            return Ok(product);
        }
    }
}
