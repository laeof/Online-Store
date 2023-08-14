using Factories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Online_Store.Domain;
using Online_Store.Domain.Entities;
using Online_Store.Domain.Entities.Products;
using Online_Store.Models;
using static Factories.ProductFactoryMapping;
using System;

namespace Online_Store.Controllers.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class GoodsController : ControllerBase
    {
        private DataManager _dataManager;
        private ProductFactoryMapping _productFactoryMapping;
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
        [HttpPost("product/create")]
        public async Task<IActionResult> CreateProduct(ProductViewModel model)
        {
            /**/

            Type productType = CategoryProductTypeMapper.GetProductType(model.CategoryId);
            ProductFactory<Product> factory = CategoryProductTypeMapper.GetProductFactory(productType);

            Product product = await factory.CreateProduct(model);

            return Ok();
        }
        [HttpPost("category/create")]
        public async Task<IActionResult> CreateCategory(Category model)
        {
            var category = new Category{
                Name = model.Name,
                ImgPath = model.ImgPath
            };

            await _dataManager.Categories.SaveCategoryAsync(category);

            return Ok();
        }
    }
}
