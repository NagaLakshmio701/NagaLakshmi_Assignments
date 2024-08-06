using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using HandsonAPIusingEFCodeFirst.Entities;
using HandsonAPIusingEFCodeFirst.Repositories;

namespace HandsonAPIusingEFCodeFirst.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepository _productRepository;

        public ProductController()
        {
            _productRepository = new ProductRepository();
        }



        [HttpGet]
        [Route ("GetAllProducts")]
        public IActionResult GetAllProduct()
        {
            var products= _productRepository.GetAllProducts();
            return StatusCode(200,products);

        }
        [HttpGet]
        [Route("GetAllProducts/{id}")]

        public IActionResult GetProduct(int id)
        {
            var product = _productRepository.GetProduct(id);
            if (product != null)
            {
                return StatusCode(200, product);
            }
            return StatusCode(404, "NOT Found");
        }

        [HttpPost]
        [Route ("AddProduct")]

        public IActionResult Add(Product product)
        {
            _productRepository.Add(product);
            return StatusCode(200, product);


        }

        [HttpPost]
        [Route ("update")]

        public IActionResult UpdateProduct(Product product)
        {
            _productRepository.UpdateProduct(product); 
            return StatusCode(200, product);
        }

        [HttpPost]
        [Route("delete")]

        public IActionResult Delete(int id)
        {
            _productRepository.Delete(id);
            return Ok();
        }

    }
}
