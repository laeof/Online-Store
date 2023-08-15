using Microsoft.AspNetCore.Mvc;
using Online_Store.Domain.Entities;
using Online_Store.Domain;

namespace Online_Store.Controllers.Api
{
    public class CategoryController: ControllerBase
    {
        private readonly DataManager _dataManager;
        public CategoryController(DataManager dataManager)
        {
            _dataManager = dataManager;
        }
        [HttpPost("category/create")]
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
    }
}
