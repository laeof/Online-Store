using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Online_Store.Domain;
using Online_Store.Domain.Entities;

namespace Online_Store.Controllers.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class GoodsController : ControllerBase
    {
        private DataManager _dataManager;
        public GoodsController(DataManager dataManager) 
        {
            _dataManager = dataManager;
        }

        [HttpGet("product")]
        public IActionResult GetProducts()
        {
            var products = _dataManager.Products.GetProducts().Select(product => new
            {
                product.Name,
                product.Description,
                product.Price,
                product.Amount,
                product.Id,
                product.Created,
                Images = product.Images.Select(image => new
                {
                    image.FileName
                }).ToList()
            });

            return Ok(products);
        }

        [HttpGet("product/{id}")]
        public async Task<IActionResult> GetProductById(Guid id)
        {
            var product = await _dataManager.Products.GetProductByIdAsync(id);
            var productImages = _dataManager.ProductImages.GetProductImagesById(id);

            if (product == null)
            {
                return NotFound();
            }

            var responseProduct = new
            {
                product.Name,
                product.Description,
                product.Price,
                product.Amount,
                product.Id,
                product.Created,
                Images = productImages.Select(image => new
                {
                    image.FileName
                }).ToList()
            };

            return Ok(responseProduct);
        }
    }
}
