using Microsoft.AspNetCore.Mvc;
using Online_Store.Domain;
using Online_Store.Domain.Entities;
using Online_Store.Domain.Entities.Products;
using Online_Store.Models;

namespace Online_Store.Controllers.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class GoodsController : ControllerBase
    {
        private readonly DataManager _dataManager;
        private readonly CategoryProductTypeMapper _productFactoryMapping;
        public GoodsController(DataManager dataManager, CategoryProductTypeMapper productTypeMapper) 
        {
            _dataManager = dataManager;
            _productFactoryMapping = productTypeMapper;
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
                product.CategoryId,
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

            var images = productImages.Select(image => new ProductImages
            {
                FileName = image.FileName
            }).ToList();

            product.Images = images;

            if (product == null)
            {
                return NotFound();
            }

            return Ok(product);
        }
        [HttpPost("create")]
        public async Task<IActionResult> CreateProduct(ProductViewModel model, [FromForm] List<IFormFile> images)
        {
            //get product type by category id
            Type productType = await _productFactoryMapping.GetProductType(model.CategoryId);

            //get factory by product type
            IProductFactory factory = _productFactoryMapping.GetFactory(productType);

            await factory.CreateProduct(model);

            foreach(IFormFile file in images)
            {

            }

            return Ok();
        }
        
    }
}
