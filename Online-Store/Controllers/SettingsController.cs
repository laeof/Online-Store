using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Online_Store.Domain;
using Online_Store.Models;

namespace Online_Store.Controllers
{
    [Authorize]
    public class SettingsController: Controller
    {
        private readonly DataManager dataManager;
        public SettingsController(DataManager dataManager) 
        {
            this.dataManager = dataManager;
        }
        [HttpGet]
        public ActionResult AddProduct()
        {
            return View(new ProductViewModel());
        }
        [HttpPost]
        public async Task<IActionResult> AddProduct(ProductViewModel model)
        {
            await dataManager.Products.SaveProductAsync(model);

            return RedirectToAction("Product", "Goods", new { id = model.Id });
        }
    }
}
