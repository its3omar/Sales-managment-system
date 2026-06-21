using Microsoft.AspNetCore.Mvc;
using SalesMS.BLL.Services;
using SalesMS.DAL.Entities;

namespace SalesMS.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly ProductService _productService;

        public ProductController(ProductService productService)
        {
            _productService = productService;
        }

        // GET api/product
        [HttpGet]
        public IActionResult GetAll()
        {
            var products = _productService.GetAllProducts();
            return Ok(products);
        }

        // GET api/product/5
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var product = _productService.GetProductById(id);

            if (product == null)
                return NotFound();

            return Ok(product);
        }

        // POST api/product
        [HttpPost]
        public IActionResult Create(Product product)
        {
            var result = _productService.CreateNewProduct(product);

            if (!result)
                return BadRequest();

            return Ok("Created");
        }

        // PUT api/product
        [HttpPut]
        public IActionResult Update(Product product)
        {
            var result = _productService.UpdateProduct(product);

            if (!result)
                return BadRequest();

            return Ok("Updated");
        }
    }
}