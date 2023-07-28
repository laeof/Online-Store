using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Online_Store.Domain;
using Online_Store.Models;
using Online_Store.Service;

namespace Online_Store.Controllers
{
	public class AccountController: Controller
	{
		private readonly DataManager dataManager;
		private readonly UserManager userManager;
		private readonly IWebHostEnvironment environment;
		public AccountController(DataManager dataManager, UserManager userManager, IWebHostEnvironment environment)
		{
			this.dataManager = dataManager;
			this.userManager = userManager;
			this.environment = environment;
		}

		[HttpGet]
		[AllowAnonymous]
		public IActionResult Login(string returnUrl)
		{
			ViewBag.Title = "Вхід";
			if (returnUrl == null)
			{
				returnUrl = "/";
			}
			if (userManager.User != null)
			{
				return Redirect("/Account/PersonalPage");
			}
			ViewBag.ReturnUrl = returnUrl;
			return View(new LoginViewModel());
		}

		[HttpPost]
		[AllowAnonymous]
		public async Task<IActionResult> Login(LoginViewModel model, string returnUrl)
		{
			if (ModelState.IsValid)
			{
				if (await Extensions.ValidateUser(model.Email, model.Password, dataManager))
				{
					await userManager.SignInAsync(model.Email);

					//редіректи

					return Redirect(returnUrl);
				}
				model.ErrorMessage = "";
				ViewBag.ReturnUrl = returnUrl;
			}
			ViewBag.Title = "Вхід";
			ViewBag.ReturnUrl = returnUrl;
			return View(model);
		}

		[Authorize]
		public async Task<IActionResult> Logout()
		{
			ViewBag.Title = "Вихід";
			await userManager.SignOutAsync();
			return RedirectToAction("Login");
		}

		[HttpGet]
		public IActionResult Register()
		{
			ViewBag.Title = "Створити обліковий запис";
			return View(new RegisterViewModel());
		}

		[HttpPost]
		public async Task<IActionResult> Register(RegisterViewModel model)
		{

			if (ModelState.IsValid)
			{
				//check for existing
				var existingUser = await dataManager.Users.GetUsers().FirstOrDefaultAsync(u => u.Email.ToLower() == model.Email.ToLower());
				if (existingUser != null)
				{
					ModelState.AddModelError(string.Empty, "Користувач з таким логіном вже існує");
					return View(model);
				}

				await userManager.SingUpAsync(model);

				// redirect to users
				return Redirect("/User/Users");
			}

			// if invalid register again
			return View(model);
		}
	}
}
