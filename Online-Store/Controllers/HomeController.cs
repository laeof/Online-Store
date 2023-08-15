using Microsoft.AspNetCore.Mvc;
using Online_Store.Domain;
using Online_Store.Domain.Entities;
using Online_Store.Models;
using System.Reflection;

namespace Online_Store.Controllers
{
    public class HomeController : Controller
    {
        private readonly CategoryProductTypeMapper _productFactoryMapping;
        private readonly DataManager _dataManager;

        public HomeController(CategoryProductTypeMapper productFactoryMapping, DataManager dataManager)
        {
            _productFactoryMapping = productFactoryMapping;
            _dataManager = dataManager;
        }
        public async Task<IActionResult> Index()
        {
            
            return View();
        }
    }
}
