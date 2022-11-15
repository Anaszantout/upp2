using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using upp2.Context;
using upp2.Models;

namespace upp2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly DataContext _context;

        public ProductsController(DataContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<IActionResult> Create(Product product)
        {
            var productModel = new ProductModel
            {
                Id = Guid.NewGuid(),
                PartitionKey = "Products",
                Name = product.Name,
                Price = product.Price,
                Description = product.Description
            };

            _context.Add(productModel);
            await _context.SaveChangesAsync();

            return new OkObjectResult(productModel);
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return new OkObjectResult(await _context.Products.ToListAsync());
        }
    }
}

