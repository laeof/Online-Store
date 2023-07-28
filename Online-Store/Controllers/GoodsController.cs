using Microsoft.AspNetCore.Mvc;

namespace Online_Store.Controllers
{
	public class GoodsController: Controller
	{
		public IActionResult Product()
		{
			return View();
		}
	}
}
