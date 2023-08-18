using Microsoft.AspNetCore.Mvc;
using Online_Store.Domain;
using Online_Store.Domain.Entities;
using Online_Store.Models;

namespace Online_Store.Controllers.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class GoodsController : ControllerBase
    {
        private readonly DataManager _dataManager;
        private readonly CategoryProductTypeMapper _productFactoryMapping;
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
                product.CategoryId,
                Images = productImages.Select(image => new
                {
                    image.FileName
                }).ToList()
            };

            return Ok(responseProduct);
        }
        [HttpPost("product/create")]
        public async Task<IActionResult> CreateProduct(ProductViewModel model)
        {
            //get product type by category id
            Type productType = await _productFactoryMapping.GetProductType(model.CategoryId);

            //get factory by product type
            IProductFactory factory = _productFactoryMapping.GetFactory(productType);

            /*var product = new ProductViewModel
            {
                Name = model.Name,
                Description = model.Description,
                Price = model.Price,
                SalePrice = model.SalePrice,
                Amount = model.Amount,
                CategoryId = model.CategoryId,
                Color = model.Color,
                Weight = model.Weight,
                Size = model.Size,
                Created = model.Created,
                Guarantee = model.Guarantee,
                Kit = model.Kit,
                Country = model.Country,
                Additional = model.Additional
            };*/

            factory.CreateProduct(model);

            return Ok();
        }
        
    }
}
