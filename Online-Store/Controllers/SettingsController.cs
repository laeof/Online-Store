using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Online_Store.Domain;
using Online_Store.Domain.Entities;
using Online_Store.Domain.Entities.Products;
using Online_Store.Models;
using System;

namespace Online_Store.Controllers
{
    [Authorize]
    public class SettingsController: Controller
    {
        private readonly DataManager dataManager;
        private readonly IWebHostEnvironment environment;
        public SettingsController(DataManager dataManager, IWebHostEnvironment environment)
        {
            this.dataManager = dataManager;
            this.environment = environment;
        }
        [HttpGet]
        public ActionResult AddProduct()
        {
            return View(new ProductViewModel());
        }
        [HttpPost]
        public async Task<IActionResult> AddProduct(ProductViewModel model, ICollection<IFormFile> ImageFiles)
        {/*
            if (ImageFiles != null && ImageFiles.Count > 0)
            {
                foreach(var imageFile in ImageFiles)
                {
                    string uploadsFolder = Path.Combine(environment.WebRootPath, "img", "goods");
                    string uniqueFileName = Path.GetRandomFileName() + "_" + imageFile.FileName;
                    string filePath = Path.Combine(uploadsFolder, uniqueFileName);

                    using (var fileStream = new FileStream(filePath, FileMode.Create))
                    {
                        await imageFile.CopyToAsync(fileStream);
                    }

                    var productImage = new ProductImages
                    {
                        FileName = uniqueFileName,
                        ProductId = model.Id
                    };

                    model.Images.Add(productImage);
                }
            }

            //await dataManager.Products.SaveProductAsync(model);

            foreach(var productImage in model.Images)
            {
                await dataManager.ProductImages.SaveProductImagesAsync(productImage);
            }

            return RedirectToAction("Product", "Goods", new { id = model.Id });*/
            return View();
        }
    }
}
