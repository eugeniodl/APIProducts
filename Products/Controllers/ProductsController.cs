using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Products.Repository.IRepository;

namespace Products.Controllers
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
        public IActionResult Get() => Ok(_productRepo.GetProducts());

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult GetById(int id)
        {
            var product = _productRepo.GetById(id);
            if(product == null)
                return NotFound();

            return Ok(product);
        }
    }
}
