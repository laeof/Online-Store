using Microsoft.AspNetCore.Mvc;
using Online_Store.Models;
using Online_Store.Domain;

namespace Online_Store.Components
{
    public class NoveltiesViewComponent: ViewComponent
    {
        private readonly UserManager userManager;
        private readonly DataManager dataManager;
        public NoveltiesViewComponent(UserManager userManager, DataManager dataManager)
        {
            this.userManager = userManager;
            this.dataManager = dataManager;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View(new ProductViewModel
            {
                Products = dataManager.Products.GetProducts()
            });
        }
    }
}
