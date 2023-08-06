using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Online_Store.Domain;
using Online_Store.Domain.Entities;

namespace Online_Store.Controllers.Api
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles = "Admin, Manager")]
    public class GoodsController : ControllerBase
    {
        private DataManager dataManager;
        public GoodsController(DataManager dataManager) 
        {
            this.dataManager = dataManager;
        }

        [HttpGet("product")]
        public IActionResult GetProducts()
        {
            return Ok(dataManager.Products.GetProducts());
        }

        [HttpGet("product/{id}")]
        public async Task<IActionResult> GetProductById(Guid id)
        {
            var product = await dataManager.Products.GetProductByIdAsync(id);
            if (product == null)
            {
                return NotFound();
            }

            return Ok(product);
        }
    }
}
