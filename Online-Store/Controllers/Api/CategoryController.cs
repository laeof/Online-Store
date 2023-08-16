using Microsoft.AspNetCore.Mvc;
using Online_Store.Domain.Entities;
using Online_Store.Domain;
using Microsoft.EntityFrameworkCore;

namespace Online_Store.Controllers.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController: ControllerBase
    {
        private readonly DataManager _dataManager;
        public CategoryController(DataManager dataManager)
        {
            _dataManager = dataManager;
        }
        [HttpPost("create")]
        public async Task<IActionResult> CreateCategory(Category model)
        {
            var category = new Category
            {
                Name = model.Name,
                ImgPath = model.ImgPath
            };

            await _dataManager.Categories.SaveCategoryAsync(category);

            return Ok();
        }
        [HttpGet("getall")]
        public IActionResult GetAllCategories()
        {
            var category = _dataManager.Categories.GetCategories().Select(category => new
            {
                category.Id,
                category.Name,
                category.ImgPath,
                Products = category.Products.Select(product => new
                {
                    product.Id
                }).ToList()
            });
            return Ok(category);
        }
        [HttpGet("getid/{id}")]
        public async Task<IActionResult> GetCategoryById(Guid id)
        {
            var category = await _dataManager.Categories.GetCategories().Where(c => c.Id == id).Select(category => new
            {
                category.Id,
                category.Name,
                category.ImgPath,
                Products = category.Products.Select(product => new
                {
                    product.Id
                }).ToList()
            }).FirstOrDefaultAsync();
            return Ok(category);
        }
    }
}
