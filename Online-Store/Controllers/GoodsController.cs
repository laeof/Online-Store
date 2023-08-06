using AutoMapper;
using Microsoft.AspNetCore.Mvc;
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
            ProductViewModel model = mapper.Map<ProductViewModel>(await dataManager.Products.GetProductByIdAsync(id));
			return View(model);
		}
	}
}
