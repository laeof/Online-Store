using Microsoft.AspNetCore.Mvc;

namespace Online_Store.Controllers
{
	public class HomeController: Controller
	{
		public IActionResult Index()
		{ 
			return View(); 
		}
	}
}
