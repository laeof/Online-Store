using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Online_Store.Domain;
using Online_Store.Models;

namespace Online_Store.Controllers
{
	public class GoodsController: Controller
	{
		private readonly IMapper mapper;
		private readonly DataManager dataManager;
		public GoodsController(DataManager dataManager, IMapper mapper)
		{
			this.dataManager = dataManager;
			this.mapper = mapper;
		}
		[HttpGet]
		public async Task<IActionResult> Product(Guid id)
		{
            var product = await dataManager.Products.GetProducts()
				.Include(p => p.Images)
				.FirstOrDefaultAsync(p => p.Id == id);

            if (product == null)
            {
                return NotFound();
            }

            var model = mapper.Map<ProductViewModel>(product);

            return View(model);
        }
	}
}
