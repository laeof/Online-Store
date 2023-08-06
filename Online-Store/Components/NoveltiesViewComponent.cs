using Microsoft.AspNetCore.Mvc;
using Online_Store.Models;
using Online_Store.Domain;
using Online_Store.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using AutoMapper;

namespace Online_Store.Components
{
    public class NoveltiesViewComponent: ViewComponent
    {
        private readonly UserManager userManager;
        private readonly DataManager dataManager;
        private readonly IMapper mapper;
        public NoveltiesViewComponent(UserManager userManager, DataManager dataManager, IMapper mapper)
        {
            this.userManager = userManager;
            this.dataManager = dataManager;
            this.mapper = mapper;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var products = mapper.Map<List<ProductViewModel>>(dataManager.Products.GetProducts()
                .Include(x => x.Images).ToList());
            return View(products);
        }
    }
}
