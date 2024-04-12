using Microsoft.AspNetCore.Mvc;
using Online_Store.Domain.Entities;
using Online_Store.Domain;
using Microsoft.EntityFrameworkCore;
using Online_Store.Models;

namespace Online_Store.Controllers.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly DataManager _dataManager;
        private readonly IWebHostEnvironment _environment;
        public CategoryController(DataManager dataManager,
                                  IWebHostEnvironment environment)
        {
            _dataManager = dataManager;
            _environment = environment;
        }
        [HttpPost("create")]
        public async Task<IActionResult> CreateCategory(CategoryViewModel model)
        {
            Category category;
            if (model.CategoryParentId != null)
            {
                category = new Category
                {
                    Name = model.Name,
                    ImgPath = model.ImgPath,
                };
            }
            else
            {
                category = new Category
                {
                    Name = model.Name,
                    ImgPath = model.ImgPath,
                    CategoryParentId = new Guid(model.CategoryParentId)
                };
            }

            await _dataManager.Categories.SaveCategoryAsync(category);

            return Ok();
        }

        [HttpPost("uploadimg")]
        public async Task<IActionResult> UploadImg([FromForm] List<IFormFile> file)
        {
            var files = file;
            var uploadedFiles = new List<string>();
            var uploadDirectory = Path.Combine(_environment.WebRootPath, "img", "category");

            foreach (var f in files)
            {
                if (f.Length > 0)
                {
                    var fileName = Path.GetFileName(f.FileName);
                    var filePath = Path.Combine(uploadDirectory, fileName);

                    using (var stream = new FileStream(filePath, FileMode.Create))
                    {
                        await f.CopyToAsync(stream);
                    }

                    uploadedFiles.Add(fileName);
                }
            }

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
                }).ToList(),
                Categories = category.Categories.Select(category => new
                {
                    category.Id
                }).ToList(),
            });
            return Ok(category);
        }
        [HttpGet("getallwithouttopcategory")]
        public IActionResult GetAllCategoriesWithoutTopCategory()
        {
            var category = _dataManager.Categories.GetCategories().Where(category => category.CategoryParentId == null).Select(category => new
            {
                category.Id,
                category.Name,
                category.ImgPath,
                Products = category.Products.Select(product => new
                {
                    product.Id
                }).ToList(),
                Categories = category.Categories.Select(category => new
                {
                    category.Id
                }).ToList(),
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
                }).ToList(),
                Categories = category.Categories.Select(category => new
                {
                    category.Id
                }).ToList(),
            }).FirstOrDefaultAsync();
            return Ok(category);
        }
    }
}
