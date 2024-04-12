using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Converters;
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
        private readonly IWebHostEnvironment _environment;
        public GoodsController(DataManager dataManager,
                                IWebHostEnvironment environment)
        {
            _dataManager = dataManager;
            _environment = environment;
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
                product.ClickCount,
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

            if (product == null)
            {
                return NotFound();
            }

            //popularity

            product.ClickCount++;

            await _dataManager.Products.SaveProductAsync(product);

            //get product:

            var productImages = _dataManager.ProductImages.GetProductImagesById(id);

            var images = productImages.Select(image => new ProductImages
            {
                FileName = image.FileName
            }).ToList();

            product.Images = images;

            return Ok(product);
        }

        [HttpPost("createcharacteristics")]
        public async Task<IActionResult> CreateCharacteristics(Characteristics characteristics)
        {
            var Characteristics = new Characteristics()
            {
                Name = characteristics.Name,
                DoubleValue = characteristics.DoubleValue,
                Value = characteristics.Value
            };

            await _dataManager.Characteristics.SaveCharacteristicsAsync(Characteristics);

            return Ok();
        }

        [HttpPost("create")]
        public async Task<IActionResult> CreateProduct(Product productData)
        {
            var product = new Product()
            {
                Name = productData.Name,
                CategoryId = productData.CategoryId,
                Color = productData.Color,
                Country = productData.Country,
                Description = productData.Description,
                Guarantee = productData.Guarantee,
                Kit = productData.Kit,
                Price = productData.Price,
                SalePrice = productData.SalePrice,
                Size = productData.Size,
                Weight = productData.Weight,
                Characteristics = productData.Characteristics,
            };

            await _dataManager.Products.SaveProductAsync(product);

            foreach (var a in productData.Images)
            {
                var imgs = new ProductImages
                {
                    ProductId = product.Id,
                    FileName = a.FileName,
                };
                await _dataManager.ProductImages.SaveProductImagesAsync(imgs);
            }

            return Ok();
        }
        [HttpPost("uploadimg")]
        public async Task<IActionResult> UploadImg([FromForm] List<IFormFile> file)
        {
            var files = file;
            var uploadedFiles = new List<string>();
            var uploadDirectory = Path.Combine(_environment.WebRootPath, "img", "goods");

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
    }
}